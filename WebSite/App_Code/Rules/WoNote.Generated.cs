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
	public partial class WoNoteBusinessRules : Planned.Data.BusinessRules
    {
        
        [RowBuilder("WoNote", RowKind.New)]
        public void BuildNewWoNote()
        {
            UpdateFieldValue("Notify", "Silvershore");
        }
    }
}
