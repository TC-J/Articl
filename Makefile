default: 

install::
	@+dotnet publish -o articl
	@+sudo install articl/articl /usr/local/bin
	
.PHONY: install
