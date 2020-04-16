# Responsive Design

**Media Queries**
Media queries are used to apply more or less CSS styling to page based on variables like screen size and device capabilities.

Use the student-tutorial along with the Tech Elevator book to become familiar with how to use media queries.


**Viewport**
When designing a responsive site, we often begin by setting the viewport meta tag. Without this, sites that were only designed for desktop screen sizes will appear visible in a mobile view, though fully zoomed out. This was an intentional design decision by mobile browser makers, as it enables the user to understand what they can zoom in on. It, however, is not ideal. A responsively designed web site is more ideal. To do this, start by setting the viewport meta tag.
`<meta name="viewport" content="width=device-width, initial-scale=1.0">`

To see an example of the zoom out in action, view the following pages on mobile and notice that the latter page looks much better. All that is different between the two is the viewport meta tag.
https://www.w3schools.com/css/example_withoutviewport.htm 
https://www.w3schools.com/css/example_withviewport.htm

Alas, the viewport has plenty more quirks that I've left out. For a significantly detailed explanation about the viewport, check out this article.
https://www.quirksmode.org/mobile/viewports.html


**Performance**
Performance is a key metric for responsive web pages. A page may be loaded on a device that is attached to a limited data plan or a limited network speed. Both of these factors will affect a users desire to visit or re-visit your web page.

According to Google, images account for 60% of the size (on average) of a web page.

Images can be dealt with in a responsive way with two common techniques.
- Art Direction: Serve different images depending on device characteristics.
- Relative Sizing: Serve the same image in different sizes, set the relative space you wish the image to occupy, and allow the browser to choose which image will be best.

I have included a demo in the image-demo folder. Load the respective html pages and resize the browser window to see the results.


**Relative vs. Absolute Sizing**
Another important technique in responsive design is using relative sizing. 

Absolutely sizing things using points or pixels takes us down a path of adaptive design, designing differently for different devices. This is simple, but ineffective. There are too many devices and device sizes to be able to create a good experience for most. 

Using relative sizing, we can present something that looks good on a broader range of screen sizes. Relative sizing is done via percentages and measurements called EM and REM.

Things sized with EM are relative to the parent element, whereas things sized with REM are relative to the root element. There is a time and place to use each of these, so familiarize yourself with both. 

I have included a demo in the size-demo folder, illustrating EM vs. REM and percentage sized containers vs pixel sized containers.

A detailed blog post on when to use REM vs. EM can be found here: https://zellwk.com/blog/rem-vs-em/


**Bulma**
Bulma is a CSS Framework. It is one of many, but I find that it is easier to use than most and offers a good balance of functionality. Bulma can be downloaded locally and placed into your project OR you can use a copy of it from a content delivery network (CDN). I have done that in my demo. 

Bulma is customizable, meaning you can define your own color scheme, sizing, fonts, etc. You can also pick and choose the parts of Bulma that you wish to include in your CSS file - again, improving the performance of your website.

Bulma offers many different tools for layout. It offers a 12 column layout that is similar to Bootstrap. It allows you to exclude column size specification to get equal columns. Bulma also offers Tiles, which are similar to a CSS grid.

Bulma includes HTML Form and other elements like Buttons that vastly improve upon the native HTML styling. 

Lastly, and perhaps most importantly, Bulma offers components that are seen on many modern web pages. Navbar, Menu, Pagination, Card, Breadcrumb, etc. These a nicely styled, pre-built components with detailed documentation on different ways to use them.

I recommend looking at their documentation: https://bulma.io/documentation/

I have included a demo in the bulma-demo folder.