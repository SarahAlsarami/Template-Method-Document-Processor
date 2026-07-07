public abstract class DocumentProcessr{
       public void Process()
    {
        openFile();
        ValidateFormat();
        saveResult();
        LogCompletion();
        ProcessContent();

    }
     private void openFile()
    {
        Console.WriteLine("Opening file...");
    }

    private void ValidateFormat()
    {
        Console.WriteLine("Validating format...");
    }

    private void saveResult()
    {
        Console.WriteLine("Saving result...");
    }

    private void LogCompletion()
    {
        Console.WriteLine("Process completed.");
    }

 protected abstract void ProcessContent();

 class PdfProcessor : DocumentProcessr
{
    protected override void ProcessContent()
    {
        Console.WriteLine("PDF: Extracting text from PDF.");
    }
}

class ExcelProcessor : DocumentProcessr
{
    protected override void ProcessContent()
    {
        Console.WriteLine("Excel: Calculating numbers and average.");
    }
}
class WordProcessor : DocumentProcessr
{
    protected override void ProcessContent()
    {
        Console.WriteLine("Word: Counting number of words.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        DocumentProcessr pdf = new PdfProcessor();
        pdf.Process();

        Console.WriteLine();

        DocumentProcessr excel = new ExcelProcessor();
        excel.Process();

        Console.WriteLine();

        DocumentProcessr word = new WordProcessor();
        word.Process();
        Console.WriteLine();
    }
    }
}


