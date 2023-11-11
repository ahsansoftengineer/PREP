## Amazon Machine Images (AMI)
- To Create an AMI from EC2 Instance
1. First Create an EC2 Instance and Install All the Packages using shell Command Script then RUN it
## Shell Script EC-2 2
```c#
#!/bin/bash
# Use this for your user data (script from top to bottom)
# install httpd (Linx 2 version)
yum update -y
yum install -y httpd
systemctl start httpd
systemctl enable httpd
```
2. Right Click on the Instance > Image and Templates > Create AMI
3. Just Name the AMI
4. You can Also Configure for Elastic Block Store
5. Setting Additional Shell Command Including AMI Commands
```c#
#!/bin/bash
# Use this for your user data (script from top to bottom)
# install httpd (Linx 2 version)
echo "<h1>Hello World from $(hostname -f)</h1>"> /var/www/html/index.html
```
6. After Creating You can See Your AMI in Images > AMIs 
7. Now You can Create EC2 Instance with this AMIs