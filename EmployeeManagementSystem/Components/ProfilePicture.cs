using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Components;

public partial class ProfilePicture
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}