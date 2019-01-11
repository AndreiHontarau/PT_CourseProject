using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ninject;
using Model;

namespace Presentation
{
    public class RentsManagementPresenter : Presenter<IRentsManagementView>
    {
        private readonly IRentsManagementService _service;
        private readonly ICustomerCardToExcelPrintingService _excelPrintingService;
        private readonly ICustomerCardToWordPrintingService _wordPrintingService;
        private readonly NameSurnamePatronymic _customerInfo;

        public RentsManagementPresenter(IKernel kernel, IRentsManagementView view, IRentsManagementService service,
            ICustomerCardToExcelPrintingService excelPrintingService, ICustomerCardToWordPrintingService wordPrintingService, NameSurnamePatronymic customerNameSurnamePatronymic)
        {
            _kernel = kernel;
            _view = view;
            _service = service;
            _wordPrintingService = wordPrintingService;
            _excelPrintingService = excelPrintingService;
            _customerInfo = customerNameSurnamePatronymic;
        }

        public override void Run()
        {
            _view.Show();
        }
    }
}
