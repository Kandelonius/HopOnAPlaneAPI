namespace LoanProgram
{
    class PageObjectTwo : IPageObject
    {
        private string pageName;

        public PageObjectTwo(string pageName = "Page Name 2")
        {
            this.pageName = pageName;
        }

        public string PageName => this.pageName;
    }
}