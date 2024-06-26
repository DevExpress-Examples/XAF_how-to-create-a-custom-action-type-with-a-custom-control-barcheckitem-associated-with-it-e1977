<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588503/15.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1977)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BarCheckItemCheckableSimpleActionControl.cs](./CS/CustomActionControl.Module.Win/ActionControls/BarCheckItemCheckableSimpleActionControl.cs) (VB: [BarCheckItemCheckableSimpleActionControl.vb](./VB/CustomActionControl.Module.Win/ActionControls/BarCheckItemCheckableSimpleActionControl.vb))
* [CheckableSimpleActionBinding.cs](./CS/CustomActionControl.Module.Win/ActionControls/CheckableSimpleActionBinding.cs) (VB: [CheckableSimpleActionBinding.vb](./VB/CustomActionControl.Module.Win/ActionControls/CheckableSimpleActionBinding.vb))
* [CheckableSimpleActionItem.cs](./CS/CustomActionControl.Module.Win/ActionItems/CheckableSimpleActionItem.cs) (VB: [CheckableSimpleActionItem.vb](./VB/CustomActionControl.Module.Win/ActionItems/CheckableSimpleActionItem.vb))
* [CustomBarActionItemsFactory.cs](./CS/CustomActionControl.Module.Win/ActionItems/CustomBarActionItemsFactory.cs) (VB: [CustomBarActionItemsFactoryProvider.vb](./VB/CustomActionControl.Module.Win/ActionItems/CustomBarActionItemsFactoryProvider.vb))
* [CustomBarActionItemsFactoryProvider.cs](./CS/CustomActionControl.Module.Win/ActionItems/CustomBarActionItemsFactoryProvider.cs) (VB: [CustomBarActionItemsFactoryProvider.vb](./VB/CustomActionControl.Module.Win/ActionItems/CustomBarActionItemsFactoryProvider.vb))
* [CustomActionControlController.cs](./CS/CustomActionControl.Module.Win/Controllers/CustomActionControlController.cs) (VB: [CustomActionControlController.vb](./VB/CustomActionControl.Module.Win/Controllers/CustomActionControlController.vb))
* [SampleController.cs](./CS/CustomActionControl.Module.Win/Controllers/SampleController.cs) (VB: [SampleController.vb](./VB/CustomActionControl.Module.Win/Controllers/SampleController.vb))
* **[CheckableSimpleAction.cs](./CS/CustomActionControl.Module/CheckableSimpleAction.cs) (VB: [CheckableSimpleAction.vb](./VB/CustomActionControl.Module/CheckableSimpleAction.vb))**
* [Order.cs](./CS/CustomActionControl.Module/Order.cs) (VB: [Order.vb](./VB/CustomActionControl.Module/Order.vb))
<!-- default file list end -->
# How to create a custom action type with a custom control (BarCheckItem), associated with it


<p>This example demonstrates how to represent an action via the BarCheckItem. For this purpose, an ActionBase descendant (CheckableSimpleAction) is implemented. This is done because it is required to save the checked state of the action. CheckableSimpleAction uses a custom action item (CheckActionItem), which represents it in the UI via a BarCheckItem. Action item is a connector between the abstract entity Action and a particular UI element. When the form's menu is created, XAF creates action items for all actions placed to this form via action containers. This operation is performed by the BarActionItemsFactory and the <a href="http://help.devexpress.com/#eXpressAppFramework/clsDevExpressExpressAppSystemModuleActionControlsSiteControllertopic">ActionControlsSiteController</a>. Since we have implemented a custom action type, it is required to implement a custom BarActionItemsFactory to assign an appropriate action item to actions of this type. The custom BarActionItemsFactory is registered via the custom factory provider (MyBarActionItemsFactoryProvider).<br> Note that in most cases, it is not required to implement a custom action and action item. It is sufficient to customize the existing action item via the BarActionItemsFactory.CustomizeActionControl event. This approach is demonstrated in the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3183"><u>How to: Customize Controls Associated with an Action</u></a> topic.<br> An example for ASP.NET is available here: <a href="https://www.devexpress.com/Support/Center/p/E4357">How to create a custom action type with a custom control in Web</a></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_how-to-create-a-custom-action-type-with-a-custom-control-barcheckitem-associated-with-it-e1977&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_how-to-create-a-custom-action-type-with-a-custom-control-barcheckitem-associated-with-it-e1977&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
