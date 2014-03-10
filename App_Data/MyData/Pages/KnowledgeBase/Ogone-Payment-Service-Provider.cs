Ogone Payment Service Provider
celio|2011/04/19 12:34:43
##PAGE##
{TOC}

'''summary''': [http://www.ogone.com|Ogone] is a provider of electronic payment and risk management services.

[^{UP(KnowledgeBase.Ogone-Payment-Service-Provider)}Ogone Beschrijving.pdf|... a pdf with an explanation of the '''configuration interface''' can be found here.]

== Parameters to post on the Ogone orderhandler page==
{|
! Parameter !! Maxlength (chars) !! Description 
|-
| pspid || NA || Ogone username
|-
| shasign || NA || SHA-1 hash from: orderid + amount + currency + pspid + salt
|-
| orderid || 30 || OrderID
|-
| amount || 15 || The amount has to be multiplied with 100. (This removes the decimals and comma-sign)
|-
| currency || 3 || The applied currency (EUR for The Netherlands).
|-
| language || 5 || The language of the Ogone page (nl_NL for The Netherlands).
|-
| title || NA || The title is shown in the header of the Ogone page.
|-
| catalogurl || 200 || 
|-
| accepturl || 200 || 
|-
| declineurl || 200 || 
|-
| exceptionurl || 200 || 
|-
| cancelurl || 200 || 
|-
| CN || 35 || The name of the customer
|-
| ownerZIP || 10 || The ZIP code of the customer
|-
| owneraddress || 35 || The address of the customer
|-
|  ||  || 
|-
|  ||  || 
|-
|  ||  || 
|-
|  ||  || 
|-
|  ||  || 
|-
|}

==Parameters Ogone posts on the webshop orderhandler page==
{|
! Parameter !! Description 
|-
| shasign || SHA-1 hash from: orderid + amount + currency + pspid + salt
|-
| orderid || OrderID
|-
| amount || The amount is multiplied with 100. (This removes the decimals and comma-sign)
|-
| currency || The applied currency.
|-
| pm || 
|-
| acceptance || 
|-
| status || 
|-
| cardno || 
|-
| payid || 
|-
| ncerror || 
|-
| brand || 
|}

== Status codes==
{|
! Code !! Description
|-
| 1 || Canceled: The payment has been canceled by the customer.
|-
| 2 || Declined: The payment has been declined (insufficient funds/to many retry's etc).
|-
| 9 || Success: The payment has been processed successfully.
|-
| 92 || Exception: It is unknown if the payment succeeded. Check the customers bankaccount for a transaction.
|}

== Implementation in EasyShop==
OrderSummary, CheckoutComplete and OrderHandler

=== OrderSummary.aspx===
* Show the order summary (shopping card + shipping information)
* After clicking the "complete order" or "betalen" button, the customer will be redirected to the Ogone payment page (form with hidden fields - parameter url).
* Important parameters (Web.config):
** '''Ogone_Url''' (https://secure.ogone.com/ncol/test/orderstandard.asp)
** '''Ogone_PSPID''' (project name - username Ogone)
** '''Ogone_catalogurl''' (page where the customer came from)
** '''Ogone_accepturl''' (url- redirect the customer to this page if the payment is successful)
** '''Ogone_declineurl''' (url - redirect the customer to this page if the payment is declined)
** '''Ogone_exceptionurl''' (url - redirect the customer to this page in-case of an exception)
** '''Ogone_cancelurl''' (url - redirect the customer to this page if the customer cancelled the payment)
** '''Ogone_SHA1_Post''' (SHA-1-IN) (hash from: orderid + amount + currency + pspid + salt)
** '''Ogone_SHA1_Get''' (SHA-1-OUT) (hash from: orderid + amount + currency + pspid + salt)

=== CheckoutComplete.aspx===
* Check the payment status (parameter in url):
** '''Success:''' show the payment success message and show the order summary (shopping card + shipping information)
** '''Cancelled''' or '''declined:''' show the payment cancelled or declined message
** '''Exception:''' show the payment exception message

=== OrderHandler.aspx===
* Check the payment status:
** '''Success:'''
**# Send an "success email" to the customer and web shop administrator
**# update the productStock
**# Add the order to the unprocessed order-list
** '''Cancelled '''or '''declined:'''
**# Add the order to the unprocessed order-list with status "cancelled"
** '''Exception:'''
**# Add the order to the unprocessed order-list with the status "exception"
**# Send an "exception email" to the customer and web shop administrator

== Accounts==
KeePass -> Online Payment Methods