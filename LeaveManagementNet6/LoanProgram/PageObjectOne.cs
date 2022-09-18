namespace LoanProgram
{
    class PageObjectOne : IPageObject
    {
        private string pageName;

        public PageObjectOne(string pageName = "Page Name 1")
        {
            this.pageName = pageName;
        }

        public string PageName => this.pageName;
    }
}