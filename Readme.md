<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631031/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2429)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Hide the group footer for a specific group level

This example implements a custom grid control with the `ShowGroupFooter` event. This event allows you to hide the group footer based on a specific condition:

```csharp
private void gridViewOverride1_ShowGroupFooter(object sender, ShowGroupFooterEventArgs e) {
  if ( e.FooterLevel == spinEdit1.Value && checkEdit1.Checked )
    e.Visible = false;
}
```


## Files to Review

* [Form1.cs](./CS/HideableGroupRowFooters/Form1.cs) (VB: [Form1.vb](./VB/HideableGroupRowFooters/Form1.vb))
* [MyGridControl.cs](./CS/HideableGroupRowFooters/CustomGridControl/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/HideableGroupRowFooters/CustomGridControl/MyGridControl.vb))
* [MyGridView.cs](./CS/HideableGroupRowFooters/CustomGridControl/MyGridView.cs) (VB: [MyGridViewInfo.vb](./VB/HideableGroupRowFooters/CustomGridControl/MyGridViewInfo.vb))
* [ShowFooterEventArgs.cs](./CS/HideableGroupRowFooters/CustomGridControl/ShowFooterEventArgs.cs) (VB: [ShowFooterEventArgs.vb](./VB/HideableGroupRowFooters/CustomGridControl/ShowFooterEventArgs.vb))


## Documentation

* [Data Summaries - WinForms Data Grid](https://docs.devexpress.com/WindowsForms/3502/controls-and-libraries/data-grid/summaries)
* [Working with Summaries in Code - Custom Summaries](https://docs.devexpress.com/WindowsForms/701/controls-and-libraries/data-grid/summaries/working-with-summaries-in-code-custom-summaries)
* [Tutorial: Group Summaries](https://docs.devexpress.com/WindowsForms/114625/controls-and-libraries/data-grid/getting-started/walkthroughs/summaries/tutorial-group-summaries)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-hide-group-footer-for-specific-level&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-hide-group-footer-for-specific-level&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
