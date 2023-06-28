using System.Text.RegularExpressions;
using System.IO;

namespace SpongebobRegexExercise;

class Program
{
    static void Main(string[] args)
    {
        string campingTranscriptPath = Path.Combine(Directory.GetCurrentDirectory(), "Spongebob_Episode_Transcript--The_Camping_Episode.txt");

        SpongebobRegexMatch(campingTranscriptPath, "seabear");
        /*** OUTPUT:
                (The seabear attacks)
                (The seabear attack Squidward)
                (The seabear comes back and attacks Squidward again)
                SpongeBob: I should have warned you about crawling. (The seabear comes back and attacks Squidward again)
                (The seabear comes back and attacks Squidward again)
                (The seabear sees the circle, points menacingly at Squidward, then leaves)
        */

        SpongebobRegexMatch(campingTranscriptPath, "^Squidward");
        /*** OUTPUT:
                Squidward: Ah, finally, the weekend is here. And this isn't just any old weekend. This is the weekend that SpongeBob and Patrick go camping. (gestures at "Dance Quarterly" calendar at a picture of SpongeBob and Patrick on the calendar) Wouldn't it be great if they got lost in the woods and never came back?
                Squidward: Ho-ho, that would be great! (gets in bed) You've waited a long time for this. A soft bed, warm tea, a good book, and two whole days with no… (imitates SpongeBob's laugh. When he stops, he can hear SpongeBob's laughter) What the…?!
                Squidward: (goes outside and sees SpongeBob and Patrick in a tent in his backyard) SpongeBob, aren't you two supposed to be camping?
                Squidward: SpongeBob, it's not camping if you're ten feet from your house.
                Squidward: No.
                Squidward: What do you mean, "have fun inside"?
                Squidward: Oh. Bye. (leaves then comes back again) You little sneak! I see what you're doing!
                Squidward: Don't think I can't see what you're doing!
                Squidward: You're saying I can't take it!
                Squidward: AH! You're saying I'm soft! You think your little "have fun inside" challenge is gonna make me come camping with you, but that is NEVER GONNA HAPPEN! There's no way I'm gonna sit out here all night with you two losers! So, get used to it! (leaves)
                Squidward: That's it! I'm in! I'll show you camping! (runs inside his house)
                Squidward: Now you'll see how a real… (falls forward into the sand from the heavy backpack) ...outdoorsman does it! (crawls out from under the backpack and gets out a cylinder looking bag) Here we are-- my remote-controlled, self-assembling tent. Watch and learn. (SpongeBob takes out binoculars while Patrick gets out a notepad and a pair glasses. Squidward throws the bag in the air then gets out the remote and pushes the button. The bag explodes and the tent, sticks, and rope fall on the ground)
                Squidward: It isn't put up yet, you idiots. (starts to mess with his tent but tears it) Huh?
                Squidward (beating the tent with a wooden stake) Bah! bah! bah!
                Squidward: Huh? Voila. (the tent collapses so Squidward rolls it up out of the way and brings back a sleeping bag) But what could compare to just lying out under the stars? (SpongeBob and Patrick applaud) Well, I've worked up an appetite as big as all outdoors. Time for a little grub. I suppose you two are gonna stew up some twigs and rocks, right?
                Squidward: Well, you two astronauts can eat marshmallows. I gonna have a can of Swedish Barnacle Balls.... (holds up the can in his hand) just as soon as I can get my can opener.
                Squidward: Why would I bother? We're ten feet from my house.
                Squidward: All right. All right. Gimme a marshmallow. (Squidward begins roasting his marshmallow until Patrick's marshmallow catches on fire and he blows it on Squidward's face. Squidward begins roasting his marshmallow until Patrick's marshmallow catches on fire and he blows it on Squidward's face again. The third shot Squidward avoids and laughs. The marshmallow flies back into Squidward's head) Ok. Besides spitting molten food stuffs at me, what else do you do for fun?
                Squidward! (silence) Good!
                Squidward: No! This is relaxing. (holds up his clarinet and plays "Kumbaya")
                Squidward: Better?! I was fine until you lodged that ballistic junk food into my windpipe!
                Squidward: A sea bear? You mean like the ones that DON'T EXIST?!
                Squidward: There's no such thing! They're just a myth!
                Squidward: (reads cover) "I Married a Sea Bear" ?
                Squidward: (reads cover) "Sea Bears and Fairy Tales Are Real?" That's the stupidest thing I've ever heard!
                Squidward: You're right! I should be more careful. In fact, why don't you tell me all of the things I shouldn't do if I want to keep the sea bears away?
                Squidward: Okay. Then what?
                Squidward: You're kidding.
                Squidward: Go on.
                Squidward: Sliced or cubed? (SpongeBob & Patrick converse quietly to each other)
                Squidward: Yeah, yeah, and?
                Squidward: Wow! That's amazing how many things can set a sea bear off. (SpongeBob and Patrick are holding each other in terror)
                Squidward: And… and suddenly I have the sense we're all in danger!
                Squidward: I don't know… (runs off and comes back wearing all the items mentioned from before) Just a feeling!!
                Squidward: Yes.
                Squidward : (continues to do whatever it takes to get a sea bear's attention)Uh! Uh! Ah! Ah! Ah! Ah! Ah! Ah! Uh! Uh! Uh! Uh! Uh! Ah! Ah! Ah!
                Squidward: (continues to do screeching like a chimpanzee) Uh! Uh! Ah! Ah! Ah! Ah! Ah! Ah! Uh!
                Squidward: (ends to screeching) Uh! Uh! Uh! Ah! Ah! Ah! Ah! (laughs) Ha! ha! ha! You guys are so gullible! See? I did everything that attracts a sea bear and nothing happened! If sea bears really exist, why didn't one show up?
                Squidward: Oh, pfft, sorry! How silly of me! You mean like this? (Squidward tilts his sombrero to the right then laughs. As he is laughing, a clawed fin turns the sombrero upside-down) Ha,ha,ha,ha,ha!...
                Squidward: AAAAAAAH! Uaaaaaaah!
                Squidward: No.
                Squidward: Are you crazy? A dirt circle won't stop that monster. I'm running for my life!
                Squidward: Thanks for the tip. I guess I'll just limp home, then.
                Squidward: Well, I guess I'll just have…
                Squidward: What'd I do that time?
                Squidward: Ok.
                Squidward: Move over!
                Squidward: Hey, it worked! You guys saved my life.
                Squidward: What attracts them?
                Squidward: (in fear) Uh-huh. 
        */
    }


    internal static void SpongebobRegexMatch(string transcriptPath, string regexPattern)
    {
        Regex pattern = new Regex(@$"{regexPattern}");

        if(File.Exists(transcriptPath))
        {
            string[] lines = File.ReadAllLines(transcriptPath);

            foreach (string line in lines)
            {
                if (pattern.IsMatch(line))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
