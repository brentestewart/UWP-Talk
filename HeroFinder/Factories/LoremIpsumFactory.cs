﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroFinder.Factories
{
    public static class LoremIpsumFactory
    {
        private static Random Random => new Random();
        public static List<string> Paragraphs => new List<string>
        {
            @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat nulla vitae metus efficitur pharetra. Donec semper magna vitae nulla tincidunt, sit amet vestibulum nisi porta. Mauris faucibus, dui at luctus consectetur, purus est imperdiet enim, et fermentum lorem erat sed justo. Vivamus volutpat in nisi a dignissim. Ut egestas, metus eget commodo eleifend, velit nunc dignissim libero, non vestibulum lectus urna nec lectus. Nunc nisl lorem, placerat luctus vestibulum a, commodo quis ante. Nulla nec condimentum ante, eu tempus elit. Mauris maximus sapien quis feugiat tincidunt. Aenean a erat quis est tincidunt rutrum. Maecenas a sem condimentum, gravida ipsum in, placerat ante. In vestibulum mi sit amet semper placerat. Suspendisse luctus, massa vitae consequat imperdiet, ligula arcu tristique ante, fermentum sodales arcu tortor sed augue. Praesent tempus est id nisi eleifend, ac commodo sem mollis. Maecenas vel ligula ultricies eros dictum consequat.",
            @"Donec porta efficitur lacus, vitae sodales nisi accumsan sed. Integer blandit quam ut quam dictum viverra. Cras finibus, tellus nec vulputate auctor, tortor mi vulputate lorem, eget elementum est magna id felis. Aliquam elementum, augue eu finibus tristique, nisl dolor pretium nisi, eget viverra neque orci consequat orci. Aenean ac pharetra felis. Curabitur ullamcorper nisi vehicula tortor suscipit elementum. Vestibulum sit amet porta ex, in viverra justo. Morbi sit amet sem rutrum, dapibus ex non, efficitur justo. Morbi sed nisl mollis, dignissim justo vitae, finibus est. Praesent mollis arcu sed nisl aliquet imperdiet. Duis efficitur, urna vel vehicula feugiat, libero mi lacinia velit, ac suscipit erat metus et turpis. Phasellus accumsan sagittis dapibus. Quisque ut tincidunt orci.",
            @"Dolor sit amet, consectetur adipiscing elit. Fusce ornare, arcu nec fringilla ullamcorper, elit ligula rhoncus ante, malesuada finibus urna est sit amet elit. Donec et justo placerat, volutpat risus at, suscipit mauris. Nulla tincidunt turpis sed neque auctor, sed blandit nibh aliquam. Vivamus magna augue, semper nec magna ac, pretium facilisis sapien. Praesent tempus odio metus, vitae auctor est condimentum sit amet. Nulla et tincidunt ligula. Aliquam magna ex, lacinia vel nunc eu, cursus vulputate augue. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ullamcorper nisl id varius fringilla. Vivamus a interdum magna.",
            @"Sed lobortis est sit amet velit luctus, et commodo massa lacinia. Phasellus fringilla a orci vel accumsan. In efficitur massa tellus, vitae gravida nisi finibus ut. Duis convallis, metus vulputate vehicula auctor, quam lectus venenatis eros, non dignissim tellus erat vel risus. Cras tincidunt sem et mi consectetur, quis tristique elit varius. Ut id dolor non diam varius suscipit sit amet ac neque. Suspendisse sed semper sem. Vivamus dui neque, rhoncus quis nulla in, sodales semper est. Sed quis semper tortor. Ut vitae dapibus risus. Vestibulum faucibus malesuada dui, at convallis tortor blandit sed.",
            @"Sed dapibus lacus dui, interdum viverra quam condimentum quis. Vestibulum pellentesque mi eu arcu gravida faucibus. Curabitur dignissim gravida euismod. Mauris egestas luctus sollicitudin. Nulla facilisi. Sed ut hendrerit arcu. Aenean nec nunc condimentum, pharetra nisi id, congue massa. Pellentesque metus massa, tempor in finibus non, malesuada vitae tellus.",
            @"Cras nec mi magna. Mauris orci augue, pharetra ac hendrerit nec, ultricies ut felis. Fusce dapibus tellus ut ante molestie, ut vehicula lacus fringilla. Etiam auctor pellentesque imperdiet. Nulla mattis vel nunc sed eleifend. Ut ut euismod purus. Donec eget arcu mi. Duis condimentum convallis est. Nullam ultrices odio at massa laoreet viverra. Vivamus augue nunc, cursus a sem vitae, auctor eleifend quam.",
            @"Fusce vulputate justo tellus, non ornare tortor tincidunt eget. Donec elementum efficitur elit ut pretium. Vivamus id mauris id tellus posuere mattis. Nulla a pellentesque sem. Maecenas est quam, sagittis ultrices nisi eu, malesuada congue dolor. Phasellus at ante non sapien euismod iaculis non non purus. Fusce non ornare turpis.",
            @"Sed ac quam in ipsum aliquet cursus nec eu nisl. Morbi accumsan dolor est, ut congue arcu vulputate sed. Sed non suscipit elit. Duis ac fringilla orci. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Praesent gravida ex nec cursus venenatis. Proin eleifend vehicula pharetra. Nunc condimentum consequat augue, ac dignissim ipsum convallis sit amet. Quisque finibus metus sed odio tincidunt commodo.",
            @"Donec porta vehicula maximus. Duis luctus lacinia massa, nec tincidunt lorem fringilla sit amet. Vestibulum quis porta nisl. Pellentesque suscipit ullamcorper neque ut lacinia. Suspendisse potenti. Ut rutrum arcu sit amet hendrerit cursus. Suspendisse potenti. Nulla vitae leo vitae lorem dictum fringilla non non metus. Morbi iaculis maximus metus. Morbi sed libero eget arcu volutpat tempus. Quisque faucibus enim elit, sit amet imperdiet odio varius sit amet. Nunc finibus lacinia dolor sed semper. Sed eu nisi magna.",
            @"Aliquam auctor, libero ac dictum iaculis, metus ligula congue nisl, a scelerisque erat massa sed felis. Pellentesque sollicitudin augue malesuada nisi condimentum pellentesque. Ut lorem nulla, euismod vel malesuada porta, scelerisque nec libero. Aliquam erat volutpat. Proin a dictum ex. Vivamus lacinia nulla eu metus fringilla, eu consequat ante scelerisque. Integer in augue sapien. Nunc commodo, odio a fermentum molestie, magna velit interdum enim, mattis malesuada metus elit fringilla nibh. Vestibulum dignissim in quam sit amet lobortis. Quisque ultrices porta felis, non placerat nunc lacinia sit amet. Aliquam erat volutpat. Vivamus dapibus velit lacus, tempor mollis lorem semper non. Aenean commodo luctus ligula vel tincidunt.",
            @"Maecenas pulvinar, quam a luctus consequat, mi urna hendrerit risus, non mattis velit tellus non libero. Praesent ac commodo felis, vitae cursus nunc. Nunc nibh sem, pharetra sed libero mollis, porttitor tempus diam. Nam finibus nunc eu erat maximus, id porttitor ipsum dapibus. Quisque quam nisl, imperdiet ac pellentesque a, malesuada quis ex. Morbi feugiat lectus sed varius lacinia. Fusce nec sapien non dui dapibus ullamcorper eleifend nec velit. Sed auctor eu nisi eu pharetra. Cras aliquet arcu in condimentum ultrices. Aliquam id mollis sem. Donec scelerisque, orci ut venenatis consectetur, odio enim hendrerit urna, vel vestibulum eros magna sit amet nunc. Mauris molestie tempor lacus eu imperdiet. Vivamus sed dapibus ligula. Praesent placerat varius orci, nec laoreet dui rutrum sit amet. Curabitur ornare augue a ex pharetra consequat.",
            @"Mauris eu commodo justo, tristique tincidunt nibh. Praesent dapibus et nisi quis ultrices. Nullam quis sagittis tortor, at condimentum enim. Quisque cursus eros nec ex vestibulum, in accumsan arcu posuere. Vestibulum volutpat accumsan ligula, eget rhoncus quam laoreet vitae. Etiam euismod ante sed ligula pharetra, nec pharetra nisi cursus. Duis eu tortor eget turpis rutrum finibus et quis leo. Etiam ultrices faucibus accumsan. Curabitur semper ligula varius, iaculis tellus finibus, gravida diam. Sed maximus, sapien id mollis tempus, nibh odio convallis augue, non congue purus dui in turpis. Nam ultrices ornare dapibus."
        };

        public static string GetRandomPassage(int numberOfParagraphs)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < numberOfParagraphs; i++)
            {
                sb.Append(Paragraphs[Random.Next(12)] + Environment.NewLine + Environment.NewLine);
            }

            return sb.ToString();
        }
    }

}