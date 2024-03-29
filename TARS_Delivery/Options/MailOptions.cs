﻿namespace TARS_Delivery.Options;

public class MailOptions
{
    public const string Mail = "Mail";

    public string Host { get; init; } = string.Empty;

    public int Port { get; init; }

    public bool EnableSSL { get; init; }

    public string Username { get; init; } = string.Empty;

    public string Password { get; init; } = string.Empty;
}
