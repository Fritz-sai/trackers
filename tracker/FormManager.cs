using System;
using System.Windows.Forms;

namespace tracker
{
    public class FormManager
    {
        private static FormManager instance;
        private DataForm dataForm;

        private FormManager() { }

        public static FormManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormManager();
                }
                return instance;
            }
        }

        public void SetDataForm(DataForm form)
        {
            dataForm = form;
        }

        public void RefreshDataForm()
        {
            if (dataForm != null)
            {
                dataForm.LoadAllData();
            }
        }
    }
} 