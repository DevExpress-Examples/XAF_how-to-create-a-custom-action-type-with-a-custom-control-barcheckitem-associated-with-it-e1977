<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588503/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1977)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to create a custom WinForms action type with a custom control (BarCheckItem), associated with it


This example demonstrates how to represent an action via BarCheckItem. For this purpose, a SimpleAction descendant ( [CheckableSimpleAction](CS/EFCore/CustomActionEF/CustomActionEF.Module/CheckableSimpleAction.cs) ) is implemented, because it is required to save the checked state of the action. To represent a custom action in a UI, the [BarCheckItemCheckableSimpleActionControl](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/BarCheckItemCheckableSimpleActionControl.cs) is used. To bind an abstract action to its UI representation, a custom [CheckableSimpleActionBinding](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/CheckableSimpleActionBinding.cs) is created. The binding operation is performed by [CustomActionControlController](CS/EFCore/CustomActionEF/CustomActionEF.Win/Controllers/CustomActionControlController.cs).

Note that in most cases, it is not required to implement a custom action and action item. It is sufficient to customize the existing action control as described in the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3183"><u>How to: Customize Controls Associated with an Action</u></a> topic.

## See Also

 - <a href="https://www.devexpress.com/Support/Center/p/E4357">How to create a custom action type with a custom control in Web</a> (ASP.NET webForms)
 - [XAF Blazor - Implement a custom Action type](https://github.com/DevExpress-Examples/xaf-custom-action-type-blazor) (ASP.NET Core Blazor Server)

<br/>

*Files to look at:*  
[CheckableSimpleAction.cs](CS/EFCore/CustomActionEF/CustomActionEF.Module/CheckableSimpleAction.cs)  
[CustomActionControlController.cs](CS/EFCore/CustomActionEF/CustomActionEF.Win/Controllers/CustomActionControlController.cs)  
[CheckableSimpleActionBinding.cs](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/CheckableSimpleActionBinding.cs)  
[BarCheckItemCheckableSimpleActionControl.cs](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/BarCheckItemCheckableSimpleActionControl.cs)  
