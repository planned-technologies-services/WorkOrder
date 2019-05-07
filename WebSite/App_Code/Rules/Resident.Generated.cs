﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using Planned.Data;

namespace Planned.Rules
{
	public partial class ResidentBusinessRules : Planned.Data.BusinessRules
    {
        
        [RowBuilder("Resident", RowKind.New)]
        public void BuildNewResident()
        {
            UpdateFieldValue("IsActive", 1);
        }
    }
}
