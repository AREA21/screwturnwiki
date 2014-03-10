Text Resize (javascript)
robvdkamp|2010/03/24 15:41:34
##PAGE##
{TOC}
===Static===

If you want to give your site’s visitors the possibility to see your page’s content at different text sizes, you can do it with the following javascript text resize solution.
Add the following javascript to your webpage.

<code html><script type="text/javascript" language="javascript">
        function fsize(size, unit, id)
        {
            var vfontsize = document.getElementById(id);
            if (vfontsize) 
            {
                vfontsize.style.fontSize = size + unit;
            }
        }
</script></code>
* size = new font size
* unit = (eenheid) pixels
* id = div/table/page id

Add buttons/links/urls to increase or reduce the font size.

Increase the font size:
<code html><a href="javascript:fsize(18,'px','content');">Increase size</a></code>

Reduce the font size:
<code html><a href="javascript:fsize(18,'px','content');">Reduce size</a></code>

===Dynamic===

If you want the resizing to be dynamic add the following code to the javascript:
<code javascript>var textsize = 10;
function changetextsize(up)
{
  if(up)
  {
    textsize = parseFloat(textsize)+2;
  }
  else
  {
    textsize =parseFloat(textsize)-2;
  }
}</code>

Add an onClick event to the buttons/links/urls
<code html><a href="javascript:fsize(textsize,'px','content');" onclick="changetextsize(1);">Increase size</a>
<a href="javascript:fsize(textsize,'px','content');" onclick="changetextsize(0);">Reduce size</a></code>

===Reset font size===
<code html><a href="javascript:fsize(10,’px’,'content’);" onclick="textsize = 10">Reset font size</a></code>