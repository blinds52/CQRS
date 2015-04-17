﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Cqrs.Commands;
using Cqrs.Configuration;
using Cqrs.Domain;
using Cqrs.Logging;

namespace MyCompany.MyProject.Domain.Inventory.Commands.Handlers
{
	[GeneratedCode("CQRS UML Code Generator", "1.500.480.367")]
	public  partial class RemoveItemsFromInventoryCommandHandler : ICommandHandler<System.Guid, RemoveItemsFromInventoryCommand>
	{
		protected IUnitOfWork<System.Guid> UnitOfWork { get; private set; }

		protected IDependencyResolver DependencyResolver { get; private set; }

		protected ILog Log { get; private set; }

		public RemoveItemsFromInventoryCommandHandler(IUnitOfWork<System.Guid> unitOfWork, IDependencyResolver dependencyResolver, ILog log)
		{
			UnitOfWork = unitOfWork;
			DependencyResolver = dependencyResolver;
			Log = log;
		}

		public long Count { get; set; }


		#region Implementation of ICommandHandler<in RemoveItemsFromInventory>

		public void Handle(RemoveItemsFromInventoryCommand command)
		{
			OnHandle(command);
		}

		#endregion
		partial void OnHandle(RemoveItemsFromInventoryCommand command);

	}
}