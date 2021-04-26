# DiscordOutputBinding

An Azure Function binding extension that enables your function app to send messages to a Discord channel, using a webhook.

This project is mainly used as an example of how to implement your own custom Azure Functions bindings, and should not be considered optimized code. Associated with this project is a [blog post which can be found here](https://www.pipehow.tech/new-azurefunctioncustombinding/).

## DiscordBinding

The DiscordBinding project contains the binding extension code, implementing an output binding which posts to Discord using a webhook.

The binding extension reads the webhook URL from an application setting called DiscordWebhookUrl by default, configured as a connection string in the Attribute class.

## DiscordFunctionCSharp

DiscordFunctionCSharp is an example function on how to implement the custom binding in C# using an assembly reference.

In the current configuration, messages should be provided as a query parameter called `content`.

The binding extension reads the webhook URL from an application setting called DiscordWebhookUrl by default. Specify another application setting in the DiscordWebhookUrl configuration in HttpTriggerDiscord.cs if needed.

## DiscordFunctionPowerShell

DiscordFunctionPowerShell is an example function on how to implement the custom binding in PowerShell using an assembly reference.

Before starting the function, the extension must be installed. The easiest way to do this is using the [Azure Function Core Tools](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local), see the blog post for more information.

In the current configuration, messages should be provided as a query parameter called `message`.

The binding extension reads the webhook URL from an application setting called DiscordWebhookUrl by default as a connection string. Specify another application setting in the connection property of the function.json file if needed.
