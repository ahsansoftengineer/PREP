# AWS
## Shell Script EC-2 1
```c#
#!/bin/bash

apt-get-update
apt-get install nginx -y
echo "WelCome to learning-ocean.com"> /var/www/html/index.html

// Windows 10, 11 Powershell Command
ssh -i PEM_FILE_NAME.pem ec2-user@ec2-0-0-0-0.ap-northeast-1.compute.amazonaws.com
ssh -i PEM_FILE_NAME.pem ec2-0-0-0-0.ap-northeast-1.compute.amazonaws.com
sudo shutdown now
```
## Shell Script EC-2 2
```c#
#!/bin/bash
# Use this for your user data (script from top to bottom)
# install httpd (Linx 2 version)
yum update -y
yum install -y httpd
systemctl start httpd
systemctl enable httpd
echo "<h1>Hello World from $(hostname -f)</h1>"> /var/www/html/index.html

// Windows 10, 11 Powershell Command
// SSH Command, Pem File, DefaultUser@Public IP Address
ssh -i PEM_FILE_NAME.pem ec2-user@0.0.0.0
ssh -i PEM_FILE_NAME.pem ec2-user@0.0.0.0

// Run the folling Commands and Making the Connection
ping google.com
whoami

// Incase If you are Facing Problem
// Make Sure You are the Owner of this File
// Right Click on the PemFile.pem > Properties > Security > Advance > Permission > Add
// Here you can Set the Owner of the File
```
