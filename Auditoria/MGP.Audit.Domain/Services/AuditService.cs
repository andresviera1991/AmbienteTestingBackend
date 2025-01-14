using AutoMapper;
using MGP.Audit.Domain.interfaces;
using MGP.Audit.Persistance.DTOs.Audit;
using MGP.Audit.Persistance.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Audit.Domain.Services
{
    public class AuditService : IAuditService
    {
        private readonly IAuditRepository _auditRepository;
        private readonly IMapper _mapper;

        public AuditService(IAuditRepository auditRepository, IMapper mapper)
        {
            _mapper = mapper;
            _auditRepository = auditRepository;
        }

        public async Task CreateAuditAsync(AuditData auditData)
        {
            auditData.NewValue = RemoveNulls(auditData.NewValue);

            if(!string.IsNullOrEmpty(auditData.OldValue))
                auditData.OldValue = JsonConvert.SerializeObject(RemoveNullProperties(auditData.NewValue, auditData.OldValue));

            if (!auditData.NewValue.Equals(auditData.OldValue))
                await _auditRepository.CreateAuditAsync(_mapper.Map<Persistance.Data.Tables.Audit>(auditData));
        }

        private static JObject RemoveNullProperties(string newValue, string oldValue)
        {
            var newValueJson = JObject.Parse(RemoveNulls(newValue));
            var oldValueJson = JObject.Parse(oldValue);
            var resultJson = new JObject();

            ReplaceNestedProperties(newValueJson, oldValueJson, resultJson);

            return resultJson;
        }

        private static void ReplaceNestedProperties(JObject newJson, JObject oldJson, JObject resultJson)
        {
            foreach (var property in newJson.Properties())
            {
                if (property.Value.Type == JTokenType.Object)
                {
                    var nestedObject = new JObject();
                    resultJson[property.Name] = nestedObject;
                    ReplaceNestedProperties((JObject)property.Value, (JObject)oldJson[property.Name], nestedObject);
                }
                else
                {
                    if (oldJson.ContainsKey(property.Name))
                    {
                        resultJson[property.Name] = oldJson[property.Name];
                    }
                    else
                    {
                        resultJson[property.Name] = property.Value;
                    }
                }
            }
        }

        static string RemoveNulls(string jsonString)
        {
            var jsonObject = JObject.Parse(jsonString);
            RemoveNullsRecursively(jsonObject);
            return JsonConvert.SerializeObject(jsonObject);
        }

        static void RemoveNullsRecursively(JObject jsonObject)
        {
            foreach (var property in jsonObject.Properties().ToArray())
            {
                if (property.Value is JObject childObject)
                {
                    RemoveNullsRecursively(childObject);
                    if (!childObject.HasValues)
                    {
                        property.Remove();
                    }
                }
                else if (property.Value.Type == JTokenType.Null)
                {
                    property.Remove();
                }
            }
        }

        public async Task<List<AuditData>> ListAuditAsync()
        {
            return _mapper.Map<List<AuditData>>(await _auditRepository.ListAuditAsync());
        }
    }
}