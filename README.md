<img src="http://snapkit.io/images/banner.jpg" alt="" />

Xamarin.SnapKit is a complete port in C# of SnapKit, a DSL to make Auto Layout easy on both iOS and OSX.

## Contents

- [Requirements](#requirements)
- [Migration Guides](#migration-guides)
- [Communication](#communication)
- [Installation](#installation)
- [Usage](#usage)
- [Credits](#credits)
- [License](#license)

## Requirements

- iOS 8.0+ / Mac OS X 10.11+ / tvOS 9.0+
- VisualStudio for MAC or Xamarin for VisualStudio

## Communication

- If you **need help**, use [Stack Overflow](http://stackoverflow.com/questions/tagged/snapkit). (Tag 'snapkit')
- If you'd like to **ask a general question**, use [Stack Overflow](http://stackoverflow.com/questions/tagged/snapkit).
- If you **found a bug**, open an issue.
- If you **have a feature request**, open an issue.
- If you **want to contribute**, submit a pull request.

## Usage

### Quick Start

```C#
using SnapKit;

class MyViewController: UIViewController {

    private UIView _box = new UIView();

    override void viewDidLoad()
    {
        base.viewDidLoad();

        this.View.AddSubview(box);
        _box.Snap().MakeConstraints((make) => {
           make.Width.Height.EqualTo(50);
           make.Center.EqualTo(this.View);
        });
    }

}
```

### Resources

- [Documentation](http://snapkit.io/docs/)
- [F.A.Q.](http://snapkit.io/faq/)

## Credits
- Jairo Tylera ([@jairotylera](http://jairo.me))
- Robert Payne ([@robertjpayne](https://twitter.com/robertjpayne))
- Many other contributors

## License

SnapKit is released under the MIT license. See LICENSE for details.
