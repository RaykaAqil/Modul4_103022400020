using Modul4_103022400020;

KodePaket.NamaPaket np1 = KodePaket.NamaPaket.Basic;
string kodePaket1 = KodePaket.getKodePaket(np1);
Console.WriteLine("Nama Paket : " + np1);
Console.WriteLine("Kode Paket : " + kodePaket1);

KodePaket.NamaPaket np2 = KodePaket.NamaPaket.Gaming;
string kodePaket2 = KodePaket.getKodePaket(np2);
Console.WriteLine("\nNama Paket : " + np2);
Console.WriteLine("Kode Paket : " + kodePaket2);
