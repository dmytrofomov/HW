using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._4
{
    public class DocumentModel
    {
        public DocumentWorker Document { get; set; }

        public Key Key { get; set; }

        public bool IsKeyValid { get; set; }

        public bool IsDocSaved { get; set; }
    }
}
