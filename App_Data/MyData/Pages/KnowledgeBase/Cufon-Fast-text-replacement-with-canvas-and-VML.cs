Cufon - Fast text replacement with canvas and VML
robvdkamp|2010/03/24 15:42:52
##PAGE##
{TOC}
==Cufon - Fast text replacement with canvas and VML==
===Why using Cufon===
* No plug-ins required
* Browser compatibility 
* Ease of use
* Speed

===Browser support===
*  Internet Explorer 6, 7 and 8
* Mozilla Firefox 1.5+
* Safari 3+
* Opera 9.5+
* Google Chrome 1.0+

===Links===
Cufon: [http://cufon.shoqolate.com/generate/|Cufon] <br/>
Usage: [http://wiki.github.com/sorccu/cufon/usage|http://wiki.github.com/sorccu/cufon/usage] <br/>
Generator: [http://cufon.shoqolate.com/generate|http://cufon.shoqolate.com/generate]

===Who to use===
# Get Cufon, download the YUI-compressed version of cufon - [http://cufon.shoqolate.com/js/cufon-yui.js|http://cufon.shoqolate.com/js/cufon-yui.js]
# Generate a font - [http://cufon.shoqolate.com/generate/|http://cufon.shoqolate.com/generate/]
# Replace text (Cufon.replace();)

<code html><!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<script src="cufon-yui.js" type="text/javascript"></script>
		<script src="Vegur_300.font.js" type="text/javascript"></script>
		<script type="text/javascript">
			Cufon.replace('h1');
		</script>
	</head>
	<body>
		<h1>This text will be shown in Vegur.</h1>
	</body>
</html></code>

====Making Internet Explorer behave====
Add the following code right before the closing < /body> tag:
@@<script type="text/javascript"> Cufon.now(); </script>@@

===Additional example===
<code html><!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<script src="cufon-yui.js" type="text/javascript"></script>
		<script src="AdobeGaramondPro_400-AdobeGaramondPro_700-AdobeGaramondPro_italic_400-AdobeGaramondPro_italic_700.font.js" type="text/javascript"></script>
		<script type="text/javascript">
			Cufon.replace('h1');
			Cufon.replace('a', {color: '#FF0000'});
			Cufon.replace('.test');
		</script>
		
		<style>
			.test
			{
				text-decoration:underline;
			}
		</style>
	</head>
	<body>
		<h1>Adobe Garamond Pro</h1>
		<p>Bovenstaande tekst wordt gegenereerd door Cufon.<br/>
		Search engine friendly en snel!</p>

		<p>Je geeft per tag aan (in dit geval < h1 > -zonder spaties-) welke tekst Cufon met het lettertype moet vervangen.<br/>
		Het is ook mogelijk om meerdere font-families toe te voegen. Daarnaast is het nog steeds mogelijk om CSS te gebruiken voor de opmaak!</p>

		<p>-Cufon-yui.js = 18KB<br/>
		-AdobeGaramondPro_400-AdobeGaramondPro_700-AdobeGaramondPro_italic_400-AdobeGaramondPro_italic_700.font.js = 110KB<br><br/>
		<strong>Grootte van het lettertype bestand is afhankelijk van de verschillende lettertypen (regular, bold, italic, bold italic) en Cufon config.</strong></p>
		<p><a href="http://wiki.github.com/sorccu/cufon/usage"><h1>http://cufon.shoqolate.com/generate/</h1></a></p>
		<p><a href="http://wiki.github.com/sorccu/cufon/usage"><h1>http://wiki.github.com/sorccu/cufon/usage</h1></a></p>
		<p><span class="test">Test</span></p>
	</body>
</html></code>

===Attachment===
<pre>
[http://wiki/GetFile.aspx?File=Cufon.zip&AsStreamAttachment=1&Provider=ScrewTurn.Wiki.FilesStorageProvider&IsPageAttachment=1&Page=KnowledgeBase.Cufon-Fast-text-replacement-with-canvas-and-VML&NoHit=1|Files used in the example]</pre>