using System;
using System.Collections.Generic;
public class KodePaket
{
	public string getKodePaket(string namaPaket)
	{
		Dictionary<string, string> tabelPaket = new Dictionary<string, string>()
		{
			{"Basic", "P201"},
			{"Standard", "P202"},
			{"Premium", "P203"},
			{"Unlimited", "P204"},
			{"Gaming", "P205"},
			{"Streaming", "P206"},
			{"Family", "P207"},
			{"Business", "P208"},
			{"Student", "P209"},
			{"Traveler", "P210"}
		};

		if (tabelPaket.ContainsKey(namaPaket)) {
			return tabelPaket[namaPaket];
		}
		else { 
			return "Tidak termasuk dalam daftar paket" 
		}
	}
}
