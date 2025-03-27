# tyger-csharp-examples

This repo contains an example of a container image that can function as a [Tyger](https://github.com/microsoft/tyger) run container. 

First log into a Tyger instance:

``` bash
tyger login <URL|--local>
```

Then pipe some data into `tyger run exec` using the provided run spec:

``` bash
echo hello | tyger run exec -f run.yml
```

The provided implementation just echoes the input to the output, which the above
command writes to standard out (and logs to standard error).