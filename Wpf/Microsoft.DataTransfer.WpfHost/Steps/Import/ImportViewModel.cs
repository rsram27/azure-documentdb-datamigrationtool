﻿using Microsoft.DataTransfer.WpfHost.Basics;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Microsoft.DataTransfer.WpfHost.Steps.Import
{
    sealed class ImportViewModel : BindableBase
    {
        private bool isImportRunning;
        private TimeSpan elapsedTime;
        private int transferred;
        private IReadOnlyCollection<KeyValuePair<string, Exception>> errors;

        public bool IsImportRunning
        {
            get { return isImportRunning; }
            set { SetProperty(ref isImportRunning, value); }
        }

        public TimeSpan ElapsedTime
        {
            get { return elapsedTime; }
            set { SetProperty(ref elapsedTime, value); }
        }

        public int Transferred
        {
            get { return transferred; }
            set { SetProperty(ref transferred, value); }
        }

        public IReadOnlyCollection<KeyValuePair<string, Exception>> Errors
        {
            get { return errors; }
            set { SetProperty(ref errors, value); }
        }

        public ICommand ExportErrorsToClipboard { get; private set; }

        public ICommand ExportErrorsToFile { get; private set; }

        public ImportViewModel()
        {
            ExportErrorsToClipboard = new ExportErrorsToClipboardCommand();
            ExportErrorsToFile = new ExportErrorsToFileCommand();
        }
    }
}
