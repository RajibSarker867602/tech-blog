using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.MenuModules
{
    /// <summary>
    /// Deep clone e.g....
    /// </summary>
    public class UserMenusReturnDto : ICloneable 
    {
        public UserMenusReturnDto()
        {
            MenuModules = new List<UserMenusReturnDto>();
        }
        public UserMenusReturnDto(Guid id, Guid? parentId, UserMenusReturnDto parent, string parentMenu,
            string name, string code, string route, string displayName, string pageType,
            string iconClass, int displaySequence, bool hasApprovalProcess, int level, bool isItemChecked, bool canCreate,
            bool canUpdate, bool canDelete, bool canView, bool canCheck, bool canApprove, bool canReject, ICollection<UserMenusReturnDto> menuModules)
        {
            Id = id;
            ParentId = parentId;
            Parent = parent;
            ParentMenu = parentMenu;
            Name = name;
            Code = code;
            Route = route;
            DisplayName = displayName;
            PageType = pageType;
            IconClass = iconClass;
            DisplaySequence = displaySequence;
            HasApprovalProcess = hasApprovalProcess;
            Level = level;
            IsItemChecked = isItemChecked;
            CanCreate = canCreate;
            CanUpdate = canUpdate;
            CanDelete = canDelete;
            CanView = canView;
            CanCheck = canCheck;
            CanApprove = canApprove;
            CanReject = canReject;
            MenuModules = menuModules;
        }

        public Guid Id { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        public UserMenusReturnDto Parent { get; set; }
        public string ParentMenu { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Route { get; set; }
        public string DisplayName { get; set; }
        public string PageType { get; set; }
        public string IconClass { get; set; }
        public int DisplaySequence { get; set; }
        public bool HasApprovalProcess { get; set; }
        public int Level { get; set; }
        public bool IsItemChecked { get; set; }
        public bool CanCreate { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanView { get; set; }
        public bool CanCheck { get; set; }
        public bool CanApprove { get; set; }
        public bool CanReject { get; set; }
        public ICollection<UserMenusReturnDto> MenuModules { get; set; }

        public object Clone()
        {
            return new UserMenusReturnDto(Id, ParentId, Parent, ParentMenu, Name, Code, Route, DisplayName, PageType, IconClass, DisplaySequence, HasApprovalProcess, Level, IsItemChecked, CanCreate, CanUpdate, CanDelete, CanView, CanCheck, CanApprove, CanReject, MenuModules);
        }
    }

    public class UserMenusReturnContainerDto
    {
        public UserMenusReturnContainerDto()
        {
            UserMenus = new List<UserMenusReturnDto>();
            UserReportMenus = new List<UserMenusReturnDto>();
            UserPermissions = new List<UserPermissionResponseDto>();
            UserGroupPermissions = new List<UserPermissionResponseDto>();
        }
        public ICollection<UserMenusReturnDto> UserMenus { get; set; }
        public ICollection<UserMenusReturnDto> UserReportMenus { get; set; }
        public ICollection<UserPermissionResponseDto> UserPermissions { get; set; }
        public ICollection<UserPermissionResponseDto> UserGroupPermissions { get; set; }
    }

    public class UserMenuReturnDtoForReport
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public Guid Id { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        public UserMenusReturnDto Parent { get; set; }
        public string ParentMenu { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Route { get; set; }
        public string DisplayName { get; set; }
        public string PageType { get; set; }
        public string IconClass { get; set; }
        public int DisplaySequence { get; set; }
        public bool HasApprovalProcess { get; set; }
        public int Level { get; set; }
        public bool IsItemChecked { get; set; }
        public bool CanCreate { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanView { get; set; }
        public bool CanCheck { get; set; }
        public bool CanApprove { get; set; }
        public bool CanReject { get; set; }
    }
}
