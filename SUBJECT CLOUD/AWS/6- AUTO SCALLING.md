## AUTO SCALLING
- AWS Auto Scaling monitors your applications and automatically adjusts capacity to maintain steady, predictable performance at the lowest possible cost. Using AWS Auto Scaling, it's easy to setup application scaling for multiple resources across multiple services in minutes.

1. EC2 > Side Menu > Auto Scaling Groups > Create Auto Scaling Group
2. Set Name ProjectName-ASG-AutoScaling
3. Create a Launch Template
4. Provide the Information as EC2 Template
- - name : ProjectName-EC2-LC
- - Auto Scaling Guidance : true
- - Quick Start : Amazon Linux (AMI : Amazon Linux 2023)
- - Instance Type : t2.micro (Free Tier)
- - Key Pair (Login): Don't Include in launch template
- - Network Settings : Select Existing Security Group > ProjectName_ALB_SECURITY_GROUP
- - Advance Details : User Data > 
```c#
#!/bin/bash
# Use this for your user data (script from top to bottom)
# install httpd (Linx 2 version)
yum update -y
yum install -y httpd
systemctl start httpd
systemctl enable httpd
echo "<h1>Hello World from $(hostname -f)</h1>"> /var/www/html/index.html

```
5. Set Launch Template on Auto Scaling Groups > ProjectName-EC2-LC (Launch Template)
6. Click Next > Chose Instance Launch Options Screen
7. Info : VPC Means Where you Virtual PC Availaible
8. Check All AZ (Availability Zones) 
9. Click Next (Step 3) Configure Advance Options
10. Load Balancing > Attach to an existing load balancer : true
11. Attach to an Existing Load Balancer > Chose from your load balancer Target Groups
12. Select Target Groups: ProjectName-TargetGroup-TG
13. Health Checks : EC2 + ELB > True
14. Health Check Grace Period : 5 Seconds
15. Next: Configure Group Size and Scaling Policies
16. Desired Capacity: 2 ; Minimum Capcity : 1; Maximum Capicity: 4;
17. Next: Add Notifications - Optional 
18. Next: Add Tags - Optional
19. Next: Review > Create Auto Scaling Groups
20. Click on ProjectName-ASG-AutoScaling Link
21. Goto Activity Tab > Acitivity History > Volla 
22. Goto Instance mgmt : Two Created Instance Displaed
22. Two Instance already be created Automatically with Auto Scalling
23. Goto Loud Balancer Copied the DNS Name and Check
24. After testing Delete the Below will charge the Money
- - Auto Scaling Groups
- - Load Balancer
- - Template Instance
25. Don't Need to Delete Target Group it won't charge you the money











	
	
	

	