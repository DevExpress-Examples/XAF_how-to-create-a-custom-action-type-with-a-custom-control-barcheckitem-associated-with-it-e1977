# How to create a custom action type with a custom control (BarCheckItem), associated with it


This example demonstrates how to represent an action via BarCheckItem. For this purpose, a SimpleAction descendant ( [CheckableSimpleAction](./CS/CustomActionControl.Module/CheckableSimpleAction.cs) ) is implemented, because it is required to save the checked state of the action. To represent a custom action in a UI, the [BarCheckItemCheckableSimpleActionControl](.\CS\CustomActionControl.Module.Win\ActionControls\BarCheckItemCheckableSimpleActionControl.cs) is used. To bind an abstract action to its UI representation, a custom [CheckableSimpleActionBinding](.\CS\CustomActionControl.Module.Win\ActionControls\CheckableSimpleActionBinding.cs) is created. The binding operation is performed by [CustomActionControlController](.\CS\CustomActionControl.Module.Win\Controllers\CustomActionControlController.cs)

Note that in most cases, it is not required to implement a custom action and action item. It is sufficient to customize the existing action item via the BarActionItemsFactory.CustomizeActionControl event. This approach is demonstrated in the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3183"><u>How to: Customize Controls Associated with an Action</u></a> topic.
An example for ASP.NET is available here: <a href="https://www.devexpress.com/Support/Center/p/E4357">How to create a custom action type with a custom control in Web</a></p>

<br/>

Files to look at:

[CS\CustomActionControl.Module\CheckableSimpleAction.cs](.\CS\CustomActionControl.Module\CheckableSimpleAction.cs)
[CS\CustomActionControl.Module.Win\Controllers\CustomActionControlController.cs](.\CS\CustomActionControl.Module.Win\Controllers\CustomActionControlController.cs)
[CS\CustomActionControl.Module.Win\ActionControls\CheckableSimpleActionBinding.cs](.\CS\CustomActionControl.Module.Win\ActionControls\CheckableSimpleActionBinding.cs)
[CS\CustomActionControl.Module.Win\ActionControls\BarCheckItemCheckableSimpleActionControl.cs](.\CS\CustomActionControl.Module.Win\ActionControls\BarCheckItemCheckableSimpleActionControl.cs)
