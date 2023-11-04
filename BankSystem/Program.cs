using BankSystem;

Console.Title = "Banky system";

CentralBank centralBank = new CentralBank("ČNB", Bank.countryResidence.CzechRepublic, "Praha 1", 0710, new Website());
Bank KB = new Bank("Komerční banka", Bank.countryResidence.CzechRepublic, "Praha 5", 0100, new Website());
Bank ČSOB = new Bank("Československá obchodní banka", Bank.countryResidence.CzechRepublic, "Praha 2", 0300, new Website());

centralBank.AddBank(KB);
centralBank.AddBank(ČSOB);

KB.centralBank = centralBank;
ČSOB.centralBank = centralBank;

ATM atm1 = new ATM();
KB.NewATM(atm1);


IndividualHuman humanForeign = new IndividualHuman("Tomi", "Paci", new DateTime(1985, 6, 12), ČSOB);
humanForeign.CreateAccount("789", 111);
Console.WriteLine(humanForeign.accountNumber);
Console.ReadKey();


IndividualHuman human = new IndividualHuman("Adam", "Bartl", new DateTime(2001, 3, 18), KB);
human.CreateAccount("123", 456);
human.LookAtAccount("123");

humanForeign.LookAtAccount("789");
human.LookAtAccount("123");

human.GoATM(atm1, 456);

centralBank.ChangeInterestRate(7);

human.TakeLoan(1500000, new DateTime(2024, 5, 12));
Console.WriteLine(human.loan);


LegalPerson legal = new LegalPerson("Zuzu", "ŽUŽU", new DateTime(1950, 1, 7), KB, "Smradík");

KB.TakeLoan(25000000, new DateTime(2027, 11, 18));
Console.WriteLine(KB.loan);

