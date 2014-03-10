KB Best Practices
celio|2009/11/11 16:07:01|(((kb,best practices)))(((BestPractices gathering)))
##PAGE##
{toc}

=== [http://apparch.codeplex.com/|Application Architecture ('''CodePlex content''')]===

=== Databases===
==== When to Use GUIDs?====
<PRE>
Use guid.comb in your database if you need guid keys but don't want to take a big performance hit - level 300
Another option (in Sql Server 2005) is NEWSEQUENTIALID(), which generates a GUID which is greater than any previous GUID 
on that computer. If you set NEWSEQUENTIALID() as the default on a PK GUID column, you'll avoid the fragmentation problem. 
</PRE>

=== Subversion Best pratices===
==== Know when to create branches ====
<pre>
This is a hotly debated question, and it really depends on the culture of your software project. Rather than prescribe a universal
policy, we'll describe three common ones here.

'''The Never-Branch system'''

(Often used by nascent projects that don't yet have runnable code.)

* Users commit their day-to-day work on /trunk.
* Occasionally /trunk "breaks" (doesn't compile, or fails functional tests) when a user begins to commit a series of complicated changes.
Pros: Very easy policy to follow. New developers have low barrier to entry. Nobody needs to learn how to branch or merge.

Cons: Chaotic development, code could be unstable at any time.

A side note: this sort of development is a bit less risky in Subversion than in CVS. Because Subversion commits are atomic, it's not 
possible for a checkout or update to receive a "partial" commit while somebody else is in the process of committing.

'''The Always-Branch system'''

(Often used by projects that favor heavy management and supervision.)

* Each user creates/works on a private branch for every coding task.
* When coding is complete, someone (original coder, peer, or manager) reviews all private branch changes and merges them to /trunk.
Pros: /trunk is guaranteed to be extremely stable at all times.

Cons: Coders are artificially isolated from each other, possibly creating more merge conflicts than necessary. Requires users to do 
lots of extra merging.

'''The Branch-When-Needed system'''

(This is the system used by the Subversion project.)

* Users commit their day-to-day work on /trunk.
* Rule #1: /trunk must compile and pass regression tests at all times. Committers who violate this rule are publically humiliated.
* Rule #2: a single commit (changeset) must not be so large so as to discourage peer-review.
* Rule #3: if rules #1 and #2 come into conflict (i.e. it's impossible to make a series of small commits without disrupting the trunk),
then the user should create a branch and commit a series of smaller changesets there. This allows peer-review without disrupting the 
stability of /trunk.
Pros: /trunk is guaranteed to be stable at all times. The hassle of branching/merging is somewhat rare.

Cons: Adds a bit of burden to users' daily work: they must compile and test before every commit.
<top>
</pre>
