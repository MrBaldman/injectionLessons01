﻿using System;
using Core;

namespace ContactManager.Contacts
{
	public class CreateContactCommand : Command
	{
		public Guid ContactId { get; set; }
		public string Name { get; set; }
		public bool Active { get; set; }
	}
}