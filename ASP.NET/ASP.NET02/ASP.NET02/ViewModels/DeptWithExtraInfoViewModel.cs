namespace ASP.NET02.ViewModels
{
    public class DeptWithExtraInfoViewModel
    {
        public string DeptName { get; set; }
        public List<string> StuNames { get; set; }
        public string State { get; set; }
    }
}

#region State 3 cases that ViewModel is a must and one of this cases Security case.
// 1- It's needed to show data from more than one entity
// 2- There's sensitive data that needs to be hidden from user 
// 3- View needs fields that doesn't exist in the database
#endregion