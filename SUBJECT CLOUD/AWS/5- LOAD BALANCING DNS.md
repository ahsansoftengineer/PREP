LOAD BALANCER

1. There are Three Types of Load Balancer
	a Application Load Balancer 	(ALB) (HTTP, HTTPS)
	b Network Load Balancer		(VPC, NLB) (TCP, UDP, TLS) -> Millions of Request
	c Getway Load Balancer		(GWLB) -> Security
2. Select Application Load Balancer
3. Set Name ProjectName-AppLoadBalance-ALB
4. Scheme (Internet-facing, IPv4)
5. Network Mapping (Check All Availability Zone AZ)
6. Security Groups (Create a Security Group) and Only Set this Security Group
	ProjectName_ALB_SECURITY_GROUP (Allow Http Inbound and Outbound Rule)
7. Listeners and Routing (Create a Target Group)
	a
	Chose Target Type (Instances)
	Target Group Name (ProjectName-TargetGroup-TG)
	Protocol HTTP 
	Protocol Version HTTP1
	b
	Register Targets
	Check Both Instances
	Click Include as Pending Below
	c
	Review Targets
	Click Create Target Group
8. Select the ProjectName-TargetGroup-TG
9. Create Load Balancer
10. Goto Load Balancer Screen and Copied DNS 
	ProjectName-AppLoadBalance-ALB-179452383.ap-northeast-1.elb.amazonaws.com
11. Now we Access the Application on Both
	IP http://18.183.136.17/, http://54.249.220.111/
	DNS http://ProjectName-AppLoadBalance-ALB-179452383.ap-northeast-1.elb.amazonaws.com
12. Now If One of the Instance Failed then Load Balancer will Handle this







