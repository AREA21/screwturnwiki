IDEAS
procm|2013/11/18 10:55:23
##PAGE##
{TOC}

<PRE>
=== current situation===
* Document Management in Subversion -> Sharepoint integration w/ Office??
* Passwords easy to get/steal -> Central Management Access Codes/Passwords. eg. Keepass
* (semi)Manual Deployments -> use better Publishing tool, eg. [http://www.iis.net/downloads/microsoft/web-deploy|WebDeploy]

* Azure vendor lock-in??? Is possible to port Apps for instance to AWS (Amazon Cloud) without to much hassle?

* Aspx View Engine -> Razor

* strip down WCF & use WebAPI? 

* Create Service Checklist (ITIL/BiSL/Six Sigma) 
** Ensure that Cache is not the cause of the problem. Clear cache CTRL+F5
** 1e Line Incident Manager/Filter??

=== Best Practices===

==== Release Management====
* [http://www.visualstudio.com/downloads/download-visual-studio-vs|Release Management for Visual Studio 2013]

==== Error Handling==== 
* Try/Catch/Finally

* Using() statement

<PRE>
'''Info''': helps to ensure that IDisposable objects such as files and fonts are handled correctly.

File and Font are examples of managed types that access unmanaged resources (in this case file handles and device contexts). There are many other kinds of unmanaged resources 
and class library types that encapsulate them. All such types must implement the IDisposable interface.

As a rule, when you use an IDisposable object, you should declare and instantiate it in a using statement. The using statement calls the Dispose method on the object in the 
correct way, and (when you use it as shown earlier) it also causes the object itself to go out of scope as soon as Dispose is called. Within the using block, the object is read-only 
and cannot be modified or reassigned.

The using statement ensures that Dispose is called even if an exception occurs while you are calling methods on the object. You can achieve the same result by putting the object 
inside a try block and then calling Dispose in a finally block; in fact, this is how the using statement is translated by the compiler. The code example earlier expands to the following 
code at compile time (note the extra curly braces to create the limited scope for the object):

{@code-csharp: 
{
  Font font1 = new Font("Arial", 10.0f);
  try
  {
    byte charset = font1.GdiCharSet;
  }
  finally
  {
    if (font1 != null)
      ((IDisposable)font1).Dispose();
  }
}
@}

</PRE>

==== Optimization & Refactoring====
'''Local variables''', place values in local variables instead of repeatably accessing external objects.
eg.:{@code-csharp:
private static void InitializeLicense()
{
	IConfigurationServiceProvider csProvider = Container.SingleInstance.Resolve<IConfigurationServiceProvider>();

	if (!String.IsNullOrEmpty(csProvider.GetConfigurationItem(ConfigurationKeys.CONF_ITEM_WINNOVATIVE_LICENSE_KEY)))
	{
		// Set the Winnovative License Key
		LicensingManager.LicenseKey = csProvider.GetConfigurationItem(ConfigurationKeys.CONF_ITEM_WINNOVATIVE_LICENSE_KEY);
	}
}
@}

==== Logging====
* Log4Net
* Windows Application log??

=== Expert Groups===
* Test Excellence
** evaluate possibilities: Microsoft Pex/Moles, Visual Studio Tools
** Advanced debugging
*** Remote Debugging, MSIL

* SQL (optimizations)

=== General===
* Solution for Duplicate files(JS, Config, etc.)
'''Matching files''':
(((...\T\MijnPost\Dev\2013_R5\MyTNT\MyTNT\Impl\PresentationLayer\Scripts\partijenpost\partijenpost.js
...\MijnPost\Dev\2013_R5\MyTNT\PPO\Impl\PresentationLayer\Scripts\partijenpost\partijenpost.js
...\MijnPost\Dev\2013_R5\MyTNT\Rapportage\Impl\PresentationLayer\Scripts\partijenpost\partijenpost.js
...\MijnPost\Dev\2013_R5\MyTNT\Share\Impl\PresentationLayer\Scripts\partijenpost\partijenpost.js
)))

* ISO certifications? (9001, 27001)
** [http://en.wikipedia.org/wiki/Incident_management_(ITSM)]
*** [http://en.wikipedia.org/wiki/ISO_20000]

* [http://www.asp.net/visual-studio/overview/2013/creating-web-projects-in-visual-studio|VisualStudio 2013, SSO & Authentication Methods]
((("ASP.NET Identity is a good choice if you are creating an Internet web site which is mainly for external customers. If your organization uses Active Directory or Office 365 and you want to 
create a project that enables single-sign-on for employees and business partners, the Organizational Accounts option might be a better choice." resource: [http://owin.org|Open Web Interface for .NET])))
</PRE>

