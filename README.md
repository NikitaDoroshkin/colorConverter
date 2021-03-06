# Color converter
Simple color converter on .NET platform.
Usage is simple and intuitive.
Enabled to convert between `RGB`, `CMYK` and `HSL` color spaces (with loss).

![main screen](https://i.ibb.co/7Q3C4M1/1.png)
![palette](https://i.ibb.co/vkZvGNb/2.png)

## .NET Winforms platform description
Windows Forms (WinForms) is a UI framework for building Windows desktop applications. It is a .NET wrapper over Windows user interface libraries, such as User32 and GDI+. It also offers controls and other functionality that is unique to Windows Forms.

Windows Forms also provides one of the most productive ways to create desktop applications based on the visual designer provided in Visual Studio. It enables drag-and-drop of visual controls and other similar functionality that make it easy to build desktop applications.

> Note: The Windows Forms visual designer is not yet available and will be part of a Visual Studio 2019 update. [See here for a workaround invoking the Classic Framework Designer](Documentation/winforms-designer.md).

To learn about project priorities as well as status and ship dates see the [Windows Forms Roadmap](roadmap.md).

This repository contains WinForms for .NET Core. It does not contain the .NET Framework variant of WinForms.

[Windows Presentation Foundation][wpf] (WPF) is another UI framework used to build Windows desktop applications which is supported on .NET Core. WPF and Windows Forms applications  run only on Windows operating systems. They are part of the `Microsoft.NET.Sdk.WindowsDesktop` SDK. You are recommended to use Visual Studio 2019 Preview 1 to use WPF and Windows Forms with .NET Core.

## Getting started

* [.NET Core 3.0 SDK Preview][.net-core-3.0-sdk-preview]
* [Getting started instructions][getting-started]
* [Contributing guide][contributing]
* [Porting guide][porting-guidelines]

## Status

We are in the process of doing four projects with Windows Forms:

1. Port Windows Forms to .NET Core.

1. Publish source to GitHub.

1. Publish (and in some cases write) tests to GitHub and enable automated testing infrastructure.

1. Enable the Visual Studio WinForms designer to work with WinForms running on .NET Core.

The first two tasks are well underway. Most of the source has been published to GitHub although we are still bringing the codebase up to functional and performance parity with .NET Framework.

We have published very few tests and have very limited coverage for PRs at this time as a result. We will be slow in merging PRs as a result. We will add more tests in 2019, however, it will be an incremental process. We welcome test contributions to increase coverage and help us validate PRs more easily.

The Visual Studio WinForms designer is not yet available and will be part of a Visual Studio 2019 update. In short, we need to move to an out-of-proc model (relative to Visual Studio) for the designer.

## How to Engage, Contribute, and Provide Feedback

Some of the best ways to contribute are to try things out, file bugs, join in design conversations, and fix issues.

* The [contributing guidelines][contributing] and the more general [.NET Core contributing guide][corefx-contributing] define contributing rules.
* The [Developer Guide][developing] defines the setup and workflow for working on this repository.
* If you have a question or have found a bug, [file an issue][issue-new].
* Use [daily builds][getting-started] if you want to contribute and stay up to date with the team.

### .NET Framework issues

Issues with .NET Framework, including WinForms, should be filed on [VS developer community][developer-community], or [Product Support][product-support]. They should not be filed on this repository.

### Reporting security issues

Security issues and bugs should be reported privately via email to the Microsoft Security Response Center (MSRC) <secure@microsoft.com>. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter][faqs-report-an-issue]. Also see info about related [Microsoft .NET Core and ASP.NET Core Bug Bounty Program][bounty-dot-net-core].

## Relationship to .NET Framework

This code base is a fork of the Windows Forms code in the .NET Framework. We intend to release .NET Core 3.0 with Windows Forms having parity with the .NET Framework version. Over time, the two implementations may diverge.

The [Update on .NET Core 3.0 and .NET Framework 4.8][update-on-net-core-3-0-and-net-framework-4-8] provides a good description of the forward-looking differences between .NET Core and .NET Framework.

## Code of Conduct

This project uses the [.NET Foundation Code of Conduct][dotnet-code-of-conduct] to define expected conduct in our community. Instances of abusive, harassing, or otherwise unacceptable behavior may be reported by contacting a project maintainer at conduct@dotnetfoundation.org.

## License

.NET Core (including the Windows Forms repository) is licensed under the [MIT license](LICENSE.TXT).
