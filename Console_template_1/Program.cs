using System;

namespace Console_template_1 // Ja izmantosi šo kodu kā template, neaizmirsti pamainīt namespace uz sava projekta nosaukumu
{
    class Program
    {
        static void Main(string[] args)
        {
			string yesno; 
			do
			{
				Console.Clear(); // Ar šo funkciju dzešam iepriekšējo izvadu no konsoles
// Viss kods, kas būs iekš šiem komentariem atkartosies kāmēr, atbildēsi ar "y".
//-------------------------atkartojama koda sākums------------------------------	

				// ReadInt32() Pielietojums:

				Console.Write("lūdzu, ievadi integer: "); //prasam lietotājam ievadīt veselo skaitli
				int ievads = ReadInt32(); //iniciējam mainīgo un _Console.ReadLine()_ vietā izsaucam mūsu funkciju

				/* Šīs kods aizvieto: int ievads = Convert.ToInt32(Console.Readline()); 
                 * Papildus tam, kāmēr Programma nesaņems pareizo ievadu, tikmēr lietotājs
                 * saņems paziņojumu par kļūdu un tiks prasīts jauns ievads, tā ka mēs
                 * varam droši izmantot uzreiz integer tipa mainīgo. */

				Console.WriteLine("Tu ievādīji: " + ievads); //izvadam ievadu

				//Funkciju izsaukt var arī šādi:
				Console.Write("vēl viens ievada variānts: ");
				Console.WriteLine("tu ievādīji pa taisno: " + ReadInt32());



//--------------------------atkartojama koda beigas-----------------------------
				Console.Write("Vēlies atkartot? (y/n): ");
				yesno = Console.ReadLine();

			}
			while (yesno == "y");

        }
        //------------------Zemāk rakstam savas funkcijas-----------------------





        //--------Zemāk ir ievada un pārbaudes funkcija priekš integer----------
		static int ReadInt32() //Ievada funkcija un pārbaude uz Int32
        {
            int checkOk; // ar šo mainīgo atgriežam funkcijas darbības rezultātu
            int output;  //šeit glabāsim starprezultātu ja TryParse atgriezīs "true"
            string input; // ar šo mainīgo nolasam ievadu
			string mistake = "It's almost certainly not an integer!"; // Teksts paziņojumam par kļūdu (šīs mainīgais nav obligāts)
			string whatToDo = "Please, try to input the digit with no coma - it certainly shoud work then: "; // Teksts kas paskaidro, ko vajag ievadīt (šīs mainīgais nav obligāts)
            bool result; // TryParse pārbaudīs mūsu ievadu un ja tas būs Int32, atgriezīs true 

            input = Console.ReadLine(); // Ievads
            result = Int32.TryParse(input, out output); // Pārbaude

            while (result == false) //Kamēr netiks saņemts Int32, cikls ziņos par kļūdu un prasīs jaunu ievadu  
            {
                Console.WriteLine(mistake); //izvada paziņojumu par kļūdu
                Console.Write(whatToDo);    //Piedāvā vēlreiz ievadīt skaitli

                input = Console.ReadLine(); // nolasa ievadu

                result = Int32.TryParse(input, out output); // pārbauda vai ir skaitlis un vai vajag atkartot visu no jauna
            }
            checkOk = output; //Ja ievadā bija skaitlis (TryParse == true) tad piešķiram to funkcijas izvadam

            return checkOk; // funkcijas izvads
		} // Šīs ir ReadInt32() funkcijas beigas
    }
}
