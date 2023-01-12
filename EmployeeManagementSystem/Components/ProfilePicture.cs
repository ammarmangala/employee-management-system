using Microsoft.AspNetCore.Components;

namespace EmployeeManagementSystem.Components;

public partial class ProfilePicture
{
    [Parameter]
    public RenderFragment? Childcontent { get; set; }
}