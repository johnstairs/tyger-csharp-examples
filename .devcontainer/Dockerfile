FROM mcr.microsoft.com/devcontainers/dotnet:1-9.0-bookworm

ARG TYGER_VERSION=0.10.1
RUN wget -O tyger_linux_x86_64.tar.gz https://github.com/microsoft/tyger/releases/download/v${TYGER_VERSION}/tyger_linux_x86_64.tar.gz \
    && tar -xzf tyger_linux_x86_64.tar.gz tyger \
    && sudo mv tyger /usr/local/bin/ \
    && sudo chmod +x /usr/local/bin/tyger \
    && rm tyger_linux_x86_64.tar.gz