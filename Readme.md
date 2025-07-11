<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1977)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF WinForms - Create a custom action type and a custom associated control (BarCheckItem)

This example implements a custom action and uses the WinForms [BarCheckItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.BarCheckItem) as a custom action control.

![CustomActionEF Win_FWqpdDPuHf](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-type-with-a-custom-control-barcheckitem-associated-with-it-e1977/assets/14300209/3658a524-a118-486a-898c-a83131b57485)


## Implementation Details

1. The [CheckableSimpleAction](CS/EFCore/CustomActionEF/CustomActionEF.Module/CheckableSimpleAction.cs) in a SimpleAction descendant that saves the checked state of the action. 
2. The [BarCheckItemCheckableSimpleActionControl](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/BarCheckItemCheckableSimpleActionControl.cs) uses the WinForms [BarCheckItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.BarCheckItem) control to implement the custom action in the UI. 
3. The [CheckableSimpleActionBinding](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/CheckableSimpleActionBinding.cs) links the custom action (`CheckableSimpleAction`) to its UI representation (`BarCheckItemCheckableSimpleActionControl`).

> **Note**:
> In most cases, it is not required to implement a custom action and action item. It is sufficient to customize the existing action control as described in the following topic: [How to: Customize Action Controls](https://docs.devexpress.com/eXpressAppFramework/113183/ui-construction/controllers-and-actions/actions/how-to-customize-action-controls).

## More Examples

 - [XAF Blazor - Implement a custom Action type](https://github.com/DevExpress-Examples/xaf-custom-action-type-blazor)
 - [XAF WebForms - Create a custom Action with a custom control](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-with-a-custom-control-in-xaf-aspnet-application-e4357)


## Files to Review
- [CheckableSimpleAction.cs](CS/EFCore/CustomActionEF/CustomActionEF.Module/CheckableSimpleAction.cs)  
- [CustomActionControlController.cs](CS/EFCore/CustomActionEF/CustomActionEF.Win/Controllers/CustomActionControlController.cs)  
- [CheckableSimpleActionBinding.cs](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/CheckableSimpleActionBinding.cs)  
- [BarCheckItemCheckableSimpleActionControl.cs](CS/EFCore/CustomActionEF/CustomActionEF.Win/ActionControls/BarCheckItemCheckableSimpleActionControl.cs)  
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-custom-action-with-custom-action-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-custom-action-with-custom-action-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
