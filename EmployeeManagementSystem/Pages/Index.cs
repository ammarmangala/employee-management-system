using EmployeeManagementSystem.Components.Widgets;

namespace EmployeeManagementSystem.Pages;

public partial class Index
{
    public List<Type> Widgets { get; set; } = new List<Type>()
    {
        typeof(EmployeeCountWidget), typeof(InboxWidget)
    };
}