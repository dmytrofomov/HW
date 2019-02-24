using System;

namespace lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter key, pres Enter to use basic version");
            var key = Console.ReadLine();
            var doc = WorkWithDocument.GetDocument(key);
            Console.WriteLine($"Document with version {doc.Key.ToString()}");

            WorkWithDocument.Listen(doc);
            Console.Read();
        }
    }

    static class WorkWithDocument
    {
        public static DocumentModel GetDocument(string key)
        {
            DocumentModel doc = new DocumentModel();

            doc.IsKeyValid = Enum.TryParse(key, out Key result);
            doc.Key = result;

            switch (result)
            {
                case Key.Pro:
                    doc.Document = new ProDocumentWorker();
                    break;
                case Key.Exp:
                    doc.Document = new ExpertDocumentWorker();
                    break;
                default:
                    doc.Document = new DocumentWorker();
                    break;
            }

            return doc;
        }

        public static void Listen(DocumentModel doc)
        {
            while (true)
            {
                Console.WriteLine("What you want to to with your document");
                var action = Console.ReadLine().ToUpper();
                bool exit = false;
                switch (action)
                {
                    case "SAVE":
                        doc.Document.SaveDocument();
                        doc.IsDocSaved = true;
                        break;
                    case "EDIT":
                        doc.Document.EditDocument();
                        doc.IsDocSaved = false;
                        break;
                    case "OPEN":
                        doc.Document.OpenDocument();
                        break;

                    case "EXIT":
                        if (!doc.IsDocSaved)
                        {
                            Console.WriteLine("Your document will be not saved");
                        }
                        exit = true;
                        break;
                }

                if (exit)
                    break;
            }
        }
    }
}
