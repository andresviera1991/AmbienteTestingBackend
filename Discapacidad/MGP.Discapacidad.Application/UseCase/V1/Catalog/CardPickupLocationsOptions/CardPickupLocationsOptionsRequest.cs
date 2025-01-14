﻿using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.Catalog.CardPickupLocationsOptions;

public class CardPickupLocationsOptionsRequest : Notifiable, IRequest<ResponseData<List<CardPickupLocationsOptionsData>, ResponseMessage>>
{
}
