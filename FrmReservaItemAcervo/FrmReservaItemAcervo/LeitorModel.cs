﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmReservaItemAcervo
{
	[Table("MvtBIBLeitor")]

	public class LeitorModel
	{
		[Key()]
		public string CodLeitor { get; set; }
		public string NomeLeitor { get; set; }
	}

}
