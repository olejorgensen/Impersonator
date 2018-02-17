
Impersonation of a user

Allows to execute code under another user context.
The account that instantiates the Impersonator class must have the 
'Act as part of operating system' privilege set.

Example:
```
using (new Impersonator( "myUsername", "myDomainname", "myPassword"))
{
	// code that executes under the new context
}
```
