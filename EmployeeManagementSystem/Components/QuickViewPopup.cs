using EmployeeManagementSystem.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Components;

public partial class QuickViewPopup
{
    [Parameter]
    public Employee? Employee { get; set; }

    private Employee? _employee;

    protected override void OnParametersSet()
    {
        _employee = Employee;
    }

    public void Close()
    {
        _employee = null;
    }
    
}