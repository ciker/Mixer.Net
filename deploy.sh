#!bin/sh

if [ "$NUGET_API_KEY" == "" ]
then
  echo "Skipping deploy"
  echo "The nuget api key is not set"
fi

if [ "$TRAVIS_BRANCH" = "master" ]
then
  dotnet pack "./src/Mixer.Net/Mixer.Net.csproj" -c "Release" -o "../../pkgs" --no-build 
  dotnet pack "./src/Mixer.Net.Core/Mixer.Net.Core.csproj" -c "Release" -o "../../pkgs" --no-build 
  dotnet pack "./src/Mixer.Net.Rest/Mixer.Net.Rest.csproj" -c "Release" -o "../../pkgs" --no-build 
  dotnet nuget push "./pkgs/*.nupkg" "$NUGET_API_KEY" -verbosity detailed
else
  echo "Skipping deploy"
  echo "This branch is not master: "$TRAVIS_BRANCH
fi
