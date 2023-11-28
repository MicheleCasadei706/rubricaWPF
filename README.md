# rubricaWPF
## Classe Contatto

### Caratteristiche del programma
* Mostra i contatti direttamente sull'interfaccia grafica
* identificatore numerico univoco per ogni contatto
* importazione di contatti tramite file CSV
   
La classe `Contatto` rappresenta un contatto con  gli attributi nome, cognome, numero di telefono, indirizzo e mail. 

### Attributi

```csharp
private int pk;
private string nome;
private string cognome;
private string numero;
private string indirizzo;
private string mail;
```
- `pk`: Un identificatore unico che rappresenta la chiave primaria del contatto.
- `nome`: Il nome del contatto.
- `cognome`: Il cognome del contatto.
- `numero`: Il numero di telefono del contatto.
- `indirizzo`: L'indirizzo del contatto.
- `mail`: L'indirizzo email del contatto.

### Proprietà

La classe fornisce proprietà pubbliche per accedere e modificare i valori degli attributi:
```csharp
public int Pk { get => pk; set => pk = value; }
public string Nome { get => nome; set => nome = value; }
public string Cognome { get => cognome; set => cognome = value; }
public string Numero { get => numero; set => numero = value; }
public string Indirizzo { get => indirizzo; set => indirizzo = value; }
public string Mail { get => mail; set => mail = value; }
```
- `Pk`: Proprietà per la chiave primaria.
- `Nome`: Proprietà per il nome del contatto.
- `Cognome`: Proprietà per il cognome del contatto.
- `Numero`: Proprietà per il numero di telefono del contatto.
- `Indirizzo`: Proprietà per l'indirizzo del contatto.
- `Mail`: Proprietà per l'indirizzo email del contatto.

### Costruttori

#### `public Contatto(string riga)`

Questo costruttore accetta una stringa che rappresenta una riga di dati CSV e inizializza gli attributi della classe `Contatto` utilizzando i dati estratti dalla stringa. 
La chiave primaria viene estratta dalla prima colonna della stringa, e se la conversione riesce, gli altri attributi vengono inizializzati. In caso contrario, la chiave primaria viene impostata a 0.

```csharp
// Costruzione di un contatto tramite il file CSV
public Contatto(string riga)
{
    // Suddivide la stringa in campi separati da punto e virgola
    string[] campi = riga.Split(';');

    // Prova a convertire la prima colonna in un intero (chiave primaria)
    if (int.TryParse(campi[0], out int res) && campi.Length == 5)
    {
        this.pk = res;
        this.Nome = campi[1];
        this.Cognome = campi[2];
        this.numero = campi[3];
        this.mail = campi[4];
    }
    else
    {
        // In caso di errore nella conversione, imposta la chiave primaria a 0
        this.pk = 0;
    }
}
```

#### `public Contatto()`

Questo costruttore crea un oggetto `Contatto` senza inizializzare alcun attributo.
```csharp
 //Creazione di un contatto vuoto
        public Contatto()
        {
        }
```
