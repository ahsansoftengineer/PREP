- useradd userName -> to Create a User

- groupadd groupName -> to Add a Group
- gpasswd -a userName groupName  -> to Add Single User to a Group
- gpasswd -M -a userName, userName2 groupName -> to add Multiple User to a Group

- usermod -aG myGroupName1 myUserName2 // Removing User from Group
- groups myUserName1 // to Check User Belongs to which Group

- cat /etc/passwd -> to See all the Users
- cat /etc/group -> to Seel all the Groups



ln fileName hardLinkName -> Hard Link
// Hard Link is Just Like a Copy except 
- Deleting Original File Or Hard Link won't effect the other
- Updating One of them effect Both of them

ln -s fileName softLinkName -> Soft Link
- Soft Link is just like shortcuts in Window
```c#
tar -csv tarFileName.tar dirNameToTar
tar -xvf tarFileName.tar
```

- Tar in archiver used to combine multiple files
- -csv Crack Verbrose Forcefully 

gzip dirName.tar -> gzip is a Compression file used to reduced the space
gunzip dirName.tar.gz -> to Unzip a File

wget -> wget is the non-interactive network downloader
	non-interactive mode means
		it still download in slow internet connection
		if you are logout it still downloads
		if it fails then it retry again to download completely

// File / Dir Access Modify 
// File / Dir Change Mode

// d-rwx-rwx-rwx
r - 4 - Read
w - 2 - Write
x - 1 - Execute

// Groups Info
Dir/File|Owner	|Group	|Others

// Groups Code
drwx-rwx-rwx -> Dir
-rwx-rwx-rwx -> File
d	|rwx	|rwx	|rwx
d	|7	|7	|7
d	|r--	|r--	|r--
d	|4	|4	|4
d	|rw-	|rw-	|rw-
d	|6	|6	|6
d	|-w-	|-w-	|-w-
d	|2	|2	|2
d	|--e	|--e	|--e
d	|1	|1	|1
chmod 000 dirX // Evenry has no Permission
chmod 777 dirX // EveryOne has Every Permission
chmod 111 dirX // EveryOne has Exec Permission
chmod 444 dirX // EveryOne has Read Permission

- Means Remove Permission
+ Add Permission
= Means Assign Permiision
u Means user/owner
g Means group
o Means others

// Assign this Permission d|rwx|r_x|r__ using Change Mode
chmod u-wx,g+w,o=wx file1
chmod u=rwx,g=rwx,o=rwx file1



	
	





