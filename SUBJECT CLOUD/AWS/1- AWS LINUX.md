# AWS LINUX
## Shell Script EC-2 1
## No Shell Script Required for AWS LINUX

## Accessing from PC
```c#
// Windows 10, 11 Powershell Command
// SSH Command, Pem File, DefaultUser@Public IP Address
cd C:\Users\ali_a\Desktop\AWS\2_PEMS
ssh -i FILE_NAME.pem ec2-0-0-0-0.ap-northeast-1.compute.amazonaws.com
ssh -i FILE_NAME.pem ec2-user@0.0.0.0
sudo shutdown now
```
### LINUX NAVIGATION KEYS
```
HJKL
```

## COMMON COMMANDS
```c#
whoami // Which User is SignIn
Ctrl + L // For Clearing Content
clear // For Clearing Content

echo // Linux is Multiple User if two Person are Using the Same User then what ever you echo the other Person will received your message
echo "My Message" >fileName // Also use for Creating a File

ls -l // All Files with details
cd // Change Directory cd ..

cp sourceFileName destinationFileName // Copy
mv srcFileName destDirName //  Move Dir and Files
```
### LINUX DIRECTORY
```c#
mkdr DirectoryName 
mkdir dir1 dir2 dir3

mkdir .HiddenDirectoryName // Create a Hidden Directory
rmdir DirectoryName // Remove Directory Empty
rmdir -p dirParent/dirChild // Remove both the parents and child dir
rmdir -pv dirParent // Remove all within the Dir and Dir
rm -r // Removes empty Dir
rm -rf dirName // Remove Force fully
rm -rm // Remove Dir and Files
pwd // Current location within Directory
```
### LINUX FILES 
```c#
cat >fileName
cat >>fileName
cat fileName // Create File / Read File
cat /etc/os-release // OS Version
cat /etc/os-rel* // Does the Same Think
touch fileName // Create / Edit File
touch -a fileName // Access Time / Hidden Files Displayed in the List
touch -m fileName // Modify Time
touch .fileName // to Hide Files
vi fileName // Create Edit File
vim fileName // Create Edit File
nano fileName // Create Edit File
stat fileName // Reading file properties
history // those commands you have used
tac fileName // Reading File Reverse

remove fileName // Deleting File
// Paging in a File
less fileName // All the Information within a Page
more fileName // Information Page by Page
head fileName // Top Ten
tail fileName // Last Ten
// To Exit from Paging Use q
```

### LINUX CAT COMMANDS
```c#
1. Root User Access = Administrator in Windows
sudo su 

2. Creating a and Concate files
cat >file1
The Content for your file would goes here
Some More Content
3. Ctrl  + D // to End File Editing
4. ls // to see all files within the directory
5. cat fileName // to read content of file
6. cat >>file2 // For Adding Content within the File
7. cat file1 file2 >file3 // Contacting and Adding Content to new File
8. cat file1 >file2 Copy and Replace file1 into file2
9. tac file1 // Reverse Reading of File
10. touch file4 file5 file6
11. cat file4
12. stat file4 // Reading file Properties (Access, Change, Modify, Birth -> Dates)

ping google.com
whoami
```
### LINUX VI EDITOR COMMANDS
```c#
1. vi filename // OPENED FILE IN EDIT MODE
2. i // Press i to Change the vi into Edit Mode
3. Press Esc
4. :w // Save
5. :wq // Save and Quite
6. :q // Quite
7. :q! Force Quite

```
### LINUX NANO EDITOR COMMANDS
```c#
1. nano fileName // Create / Open File in Edit Mode
2. Ctrl + X // Exit
3. Shift + Y // To Save
4. Shift + N // to Cancel Save
```


### LINUX YUM COMMANDS
```c#
hostname
hostname -i
ifconfig
// yum -> Yellowdog Updater Modified
// yum -> For Instal / Update / Downgrade Softwares
// httpd -> Hypertext Transfer Protocol Diamond // Apache Server // Demon
yum install httpd
yum install httpd -y // Yes to all Questions
yum remove httpd
yum update httpd

service httpd start
service httpd status

// ChkConfig -> Automatically running Service when Server Starts
chkconfig httpd on
chkconfig httpd off

which httpd // tree location of the installed Software
yum install tree -y

yum list install

```






























