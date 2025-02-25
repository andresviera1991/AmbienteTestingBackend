BEGIN;

INSERT INTO public."User" ("Id","EmployeeNumber","FirstName","LastName","DocumentNumber","UserStatusId","AreaId","CreationDate","ModifiedDate","QueuePosition","UserName","NormalizedUserName","Email","NormalizedEmail","EmailConfirmed","PasswordHash","SecurityStamp","ConcurrencyStamp","PhoneNumber","PhoneNumberConfirmed","TwoFactorEnabled","LockoutEnd","LockoutEnabled","AccessFailedCount") VALUES
	 ('ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e21b'::uuid,'123456','admin','admin','44413552',1,NULL,'2024-12-12 16:21:02-03',NULL,0,'44413552','44413552','cristian.fernandez@avalith.net','CRISTIAN.FERNANDEZ@AVALITH.NET',false,'AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==','6df4f47c-f703-4764-bdff-81a3d2c021d0',NULL,NULL,false,false,NULL,true,0),
	 ('18d14490-91c1-4ba6-843c-9b501d187049'::uuid,'882536','John','Supervisor','41139455',1,1,'2024-12-12 16:21:53-03',NULL,0,'41139455','41139455','cristian.fer.mel@gmail.com','CRISTIAN.FER.MEL@GMAIL.COM',false,'AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==','XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34','d837d926-6935-4a9c-8ab9-9d8edd1f5dcf',NULL,false,false,NULL,true,0),
	 ('18d14490-91c1-4ba6-843c-9b501d187050'::uuid,'882537','John','Agente Uno','17027227',1,1,'2024-12-12 16:21:53-03',NULL,0,'17027227','17027227','c.fernandez.melian@hotmail.com','c.fernandez.melian@hotmail.com',false,'AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==','XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34','d837d926-6935-4a9c-8ab9-9d8edd1f5dcf',NULL,false,false,NULL,true,0),
	 ('18d14490-91c1-4ba6-843c-9b501d187051'::uuid,'882538','John','Agente Dos','21004652',1,1,'2024-12-12 16:21:53-03',NULL,0,'21004652','21004652','leandro.gomez.pae@gmail.com','leandro.gomez.pae@gmail.com',false,'AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==','XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34','d837d926-6935-4a9c-8ab9-9d8edd1f5dcf',NULL,false,false,NULL,true,0);

INSERT INTO public."UserRoles" ("UserId","RoleId") VALUES
	 ('ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e21b'::uuid,'00000000-0000-0000-0000-000000000001'::uuid),
	 ('18d14490-91c1-4ba6-843c-9b501d187049'::uuid,'00000000-0000-0000-0000-000000000003'::uuid),
	 ('18d14490-91c1-4ba6-843c-9b501d187050'::uuid,'00000000-0000-0000-0000-000000000002'::uuid),
	 ('18d14490-91c1-4ba6-843c-9b501d187051'::uuid,'00000000-0000-0000-0000-000000000002'::uuid);

INSERT INTO public."AgentTicketType" ("Id", "AgentId", "TicketTypeId", "CreationDate") VALUES
	 ('ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17a'::uuid,'18d14490-91c1-4ba6-843c-9b501d187050'::uuid, 1, '2024-12-12 16:21:53-03'),
	 ('ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17b'::uuid,'18d14490-91c1-4ba6-843c-9b501d187050'::uuid, 2, '2024-12-12 16:21:53-03'),
	 ('ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17c'::uuid,'18d14490-91c1-4ba6-843c-9b501d187051'::uuid, 1, '2024-12-12 16:21:53-03'),
	 ('ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17d'::uuid,'18d14490-91c1-4ba6-843c-9b501d187051'::uuid, 2, '2024-12-12 16:21:53-03'),
	 ('ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17e'::uuid,'18d14490-91c1-4ba6-843c-9b501d187051'::uuid, 3, '2024-12-12 16:21:53-03');


INSERT INTO public."Menu" ("Id","ParentMenuId","Label","Icon","Url","Order","IsActive","Name","CreationDate","ModifiedDate") VALUES
	 (1,NULL,'Mis Tramites','','',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(2,1,'CUD','','',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(3,2,'Nuevos','','/search-by?TicketStatusId=1&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(4,2,'En proceso',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(5,4,'Vecino','','/search-by?TicketStatusId=2&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(6,4,'Agente','','/search-by?TicketStatusId=3&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(7,2,'Cerrado',NULL,'/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(51,7,'Falta de Respuesta','','/search-by?TicketStatusId=5&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(52,7,'Cerrado Otorgado','','/search-by?TicketStatusId=6&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(53,7,'Cerrado Denegado','','/search-by?TicketStatusId=7&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
			(8,2,'Cancelado',NULL,'/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(9,2,'Acceso SNR',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(10,1,'SUBE',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),	
	 		(11,10,'Nuevos',NULL,'/search-by?TicketStatusId=1&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(12,10,'En proceso',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(13,12,'Vecino',NULL,'/search-by?TicketStatusId=2&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(14,12,'Agente',NULL,'/search-by?TicketStatusId=3&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(15,10,'Cerrado',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(54,7,'Falta de Respuesta','','/search-by?TicketStatusId=5&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(55,7,'Cerrado Otorgado','','/search-by?TicketStatusId=6&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(56,7,'Cerrado Denegado','','/search-by?TicketStatusId=7&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
		(16,10,'Cancelado',NULL,'/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,'','2024-11-12 15:43:09-03',NULL),
	 	(17,10,'Acceso UTE',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(18,10,'Acceso Sube',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(19,1,'Espacio de estacionamiento',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(20,19,'Nuevos',NULL,'/search-by?TicketStatusId=1&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(21,19,'En proceso',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(22,21,'Vecino',NULL,'/search-by?TicketStatusId=2&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(23,21,'Agente',NULL,'/search-by?TicketStatusId=3&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(24,19,'Cerrado',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(57,7,'Falta de Respuesta','','/search-by?TicketStatusId=5&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(58,7,'Cerrado Otorgado','','/search-by?TicketStatusId=6&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(59,7,'Cerrado Denegado','','/search-by?TicketStatusId=7&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
			(25,19,'Cancelado',NULL,'/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
     (26,NULL,'Todos los Tramites',NULL,NULL,2,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(27,26,'CUD',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(28,27,'Nuevo',NULL,'/search-by?TicketStatusId=1&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(29,27,'En proceso',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(30,29,'Vecino',NULL,'/search-by?TicketStatusId=2&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(31,29,'Agente',NULL,'/search-by?TicketStatusId=3&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(32,27,'Cerrado',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(60,7,'Falta de Respuesta','','/search-by?TicketStatusId=5&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(61,7,'Cerrado Otorgado','','/search-by?TicketStatusId=6&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(62,7,'Cerrado Denegado','','/search-by?TicketStatusId=7&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
			(33,27,'Cancelado',NULL,'/search-by?TicketStatusId=8&ServiceName=DISCAPACIDAD&TicketTypeId=1',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(34,27,'Acceso SNR',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(35,26,'SUBE',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(36,35,'Nuevos',NULL,'/search-by?TicketStatusId=1&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(37,35,'En proceso',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(38,37,'Vecino',NULL,'/search-by?TicketStatusId=2&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(39,37,'Agente',NULL,'/search-by?TicketStatusId=3&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(40,35,'Cerrado',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(63,7,'Falta de Respuesta','','/search-by?TicketStatusId=5&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(64,7,'Cerrado Otorgado','','/search-by?TicketStatusId=6&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(65,7,'Cerrado Denegado','','/search-by?TicketStatusId=7&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(41,35,'Cancelado',NULL,'/search-by?TicketStatusId=8&ServiceName=DISCAPACIDAD&TicketTypeId=2',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(42,35,'Acceso UTE',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(43,35,'Acceso SUBE',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 	(44,26,'Espacio de Estacionamiento',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(45,44,'Nuevos',NULL,'/search-by?TicketStatusId=1&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(46,44,'En proceso',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(47,46,'Vecino',NULL,'/search-by?TicketStatusId=2&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(48,46,'Agente',NULL,'/search-by?TicketStatusId=3&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(49,46,'Cerrado',NULL,NULL,1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(66,7,'Falta de Respuesta','','/search-by?TicketStatusId=5&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 			(67,7,'Cerrado Otorgado','','/search-by?TicketStatusId=6&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
				(68,7,'Cerrado Denegado','','/search-by?TicketStatusId=7&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL),
	 		(50,46,'Cancelado',NULL,'/search-by?TicketStatusId=8&ServiceName=DISCAPACIDAD&TicketTypeId=3',1,true,NULL,'2024-11-12 15:43:09-03',NULL);



INSERT INTO public."MenuByAreaAndRole" ("RoleId","MenuId","AreaId","CreationDate","ModifiedDate") VALUES
	 ('00000000-0000-0000-0000-000000000002'::uuid,1,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,2,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,3,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,4,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,5,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,6,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,7,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,8,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,9,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,10,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,11,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,12,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,13,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,14,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,15,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,16,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,17,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,18,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,19,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,20,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,21,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,22,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,23,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,24,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,25,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,26,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,27,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,28,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,29,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,30,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,31,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,32,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,33,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,34,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,35,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,36,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,37,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,38,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,39,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,40,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,41,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,42,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,43,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,44,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,45,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,46,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,47,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,48,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,49,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000002'::uuid,50,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,26,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,27,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,28,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,29,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,30,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,31,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,32,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,33,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,34,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,35,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,36,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,37,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,38,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,39,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,40,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,41,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,42,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,43,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,44,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,45,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,46,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,47,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,48,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,49,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,50,1,'2024-11-12 15:43:09-03',NULL),
     ('00000000-0000-0000-0000-000000000003'::uuid,51,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,52,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,53,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,54,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,55,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,56,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,57,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,58,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,59,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,60,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,61,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,62,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,63,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,64,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,65,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,66,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,67,1,'2024-11-12 15:43:09-03',NULL),
	 ('00000000-0000-0000-0000-000000000003'::uuid,68,1,'2024-11-12 15:43:09-03',NULL);

COMMIT;
