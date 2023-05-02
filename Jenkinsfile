#!/usr/bin/env groovy

@Library("jenkins-shared-pipelines") _

d09Project  jenkinsCiAgent: "netcore60",
            cdSemanticRelease: true,
            cdServices: ["echo-api-v1"],
            openshiftDeployNamespace: "servicefactory",
            gitOpsPath: "echo-service/echo-api-v1",
            dotnetFolder: "src",
            dotnetSlnFile: "District09.Echo.sln", 
            dotnetTestFolder: "District09.Echo.Tests",
            dotnetTestFile: "District09.Echo.Tests.csproj",
			argoCdApplication: "echo-service",
			argoCdComponent: "echo-api"
