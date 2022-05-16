# DiffieHellman-AES
<img width="363" alt="Screenshot 2022-05-10 at PM 3 41 39" src="https://user-images.githubusercontent.com/92235772/168669321-7e4e0618-5865-41b4-b3a6-f54af5339795.png">

This project implements Diffie Hellman algorithm and AES algorithm. What this app does is
that it creates two users Alice and Bob. Those two users then generate a unique key for
themselves which are known as a & b. After this, they are to agree on two public keys p & q.
In this documentation, I will be explaining everything in detail starting off from generating
the keys up until printing the messages on the screen

Diffie Hellman algorithm:
The Diffie-Hellman algorithm is being used to establish a shared secret that can be
used for secret communications while exchanging data over a public network using
the elliptic curve to generate points and get the secret key using the parameters.
![1200px-Diffie-Hellman-Schlüsselaustausch svg](https://user-images.githubusercontent.com/92235772/168669429-d14daefd-56b5-4528-b2a5-7b9bb7bf36b4.png)

Parameters:
G:
is a very huge prime number which is practically crackable. If it was a small number, it
would have no meaning because it would be so easy to be cracked.
P:
It is a primitive root modulo of G.*
* Modulo operation is an operation where the result is the remainder of the division
operation performed with two given integers as operands.
A:
Alice’s private key
B:
Bob’s private key.

AES algorithm:
The AES Encryption algorithm (also known as the Rijndael algorithm) is a
symmetric block cipher algorithm with a block/chunk size of 128 bits. It
converts these individual blocks using keys of 128, 192, and 256 bits. Once it
encrypts these blocks, it joins them together to form the ciphertext

![security-aes_design_mobile](https://user-images.githubusercontent.com/92235772/168669643-fc3c348d-67e5-48b2-9759-84eb56f707f8.jpeg)

<img width="363" alt="Screenshot 2022-05-10 at PM 4 06 39" src="https://user-images.githubusercontent.com/92235772/168669773-5a0bccbd-d749-47d8-988c-2c5d0208e8f7.png">

Firstly, two accounts are created for the users. Technically, we have a class for creating users
calles USER. We basically call this class two times as we want to create to users.

<img width="363" alt="Screenshot 2022-05-10 at PM 4 06 59" src="https://user-images.githubusercontent.com/92235772/168669861-8d8814dd-1e3d-4a75-92f3-6a747ad9845b.png">




When we create an instance of this class, the constructor takes the users name and saves it
into a variable this.name because we will need to have the name as we will need it to keep
track from who we got the message to display his/ her name before the message.
After creating an instance, we have to initialize some variables, Private key and IV.
Private key is a method whose return type is Biginteger. It generates a random number and
then initialize private key to be them the non-sharable key.
IV is a byte array that we need it for AES algorithm. It is basically an initialization vector that
is used to ensure that the same value encrypted multiple times, even with the same secret
key, will not always result in the same encrypted value. This is an added security layer.



<img width="343" alt="Screenshot 2022-05-10 at PM 4 20 22" src="https://user-images.githubusercontent.com/92235772/168670059-a4679325-14ad-47c3-9258-34032302cc81.png">




After initializing the fields, we call a method called Generate_Key() . what this method does
is that it calculates the modulo operation and then initializes the first key calculated from the
first user.

<img width="521" alt="Screenshot 2022-05-10 at PM 4 24 20" src="https://user-images.githubusercontent.com/92235772/168670223-2bf725f7-15a2-48a8-98ea-de0600a24b9c.png">



We call this function for as many users as there are, so that it calculates the keys for the users.
This calculation is the first round.
First round:

<img width="159" alt="Screenshot 2022-05-10 at PM 4 27 35" src="https://user-images.githubusercontent.com/92235772/168670625-a6935a89-0840-4843-b381-f2b5680a7eac.png">


<img width="159" alt="Screenshot 2022-05-10 at PM 4 28 04" src="https://user-images.githubusercontent.com/92235772/168670636-d8ca1316-5f6e-47fb-825f-7c93ed5e13ab.png">




<img width="460" alt="Screenshot 2022-05-10 at PM 4 30 33" src="https://user-images.githubusercontent.com/92235772/168670417-cf27f6b5-5250-4b28-b8ce-77aae48d687f.png">


After Generating the public keys, we exchange the keys between the users.
Exchange_Keys(Biginteger GeneratedPublicKey , byte[] IV)
This method take the generated keys which are permitted to be exchanged over the network
and them calculate the second round.
Second round:

<img width="159" alt="Screenshot 2022-05-10 at PM 4 29 25" src="https://user-images.githubusercontent.com/92235772/168670501-6fae973f-d13e-4c13-88df-fc486685208e.png">

<img width="159" alt="Screenshot 2022-05-10 at PM 4 29 36" src="https://user-images.githubusercontent.com/92235772/168670528-198d3f1a-30b4-441f-b2b5-2e73a95e1f05.png">



Now everything is all set. Keys are exchanged.
For AES, it is the typical algorithm. The only thing I add to it is
<img width="767" alt="Screenshot 2022-05-10 at PM 4 38 02" src="https://user-images.githubusercontent.com/92235772/168670761-5505f786-0037-4959-9a0e-60d2ef69b0da.png">



The final keys are not consistent in bits and the size of them does not work for AES
algorithm and that what happened to me. As AES works with { 128-bit, 192-bit, 256-
bit} keys, I used that method that makes the key consistent in bits 32 byte * 8 = 256 bits.
This has a salt array filed, it is a gab sequence.

<img width="575" alt="Screenshot 2022-05-10 at PM 4 58 33" src="https://user-images.githubusercontent.com/92235772/168670845-3bfdd3ca-58f8-4f8c-9413-34e7cfd9b475.png">


IDisposable is an interface that contains a single method, Dispose(), for releasing
unmanaged resources, like files, streams, database connections and so on
