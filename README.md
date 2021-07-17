# Coub Mass Download
Programa em C# windows forms .NET Framework 4.7.2
<br><br>
Com o objetivo de realizar:
<br>
&nbsp;•Download massiso de vídeos do coub com alguns 'filtros' de busca, e unifica todos os vídeos.

Exemplo do Vídeo gerado
--------- 
 [Assistir no YOUTUBE](https://youtu.be/utNNAbg-Zuk)<br>
<a href="https://youtu.be/utNNAbg-Zuk
" target="_blank"><img src="https://raw.githubusercontent.com/DanielSvoboda/Coub_Mass_Download/main/Download/logo/logo2.jpg" 
alt="Texto ALT da imagem aqui" width="300" height="200" border="10" /></a>

  
Funções 
---------  
&nbsp;•Pegar_links&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(Faz um get no coub com o link personalisado da busca, retona um json)<br>
&nbsp;•Baixar_Coub&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(Baixar os arquivos referente aos link's armazenados na variavel links_coub)<br>
&nbsp;•Copiar_intro_fim&nbsp;(Copiar 2 arquivos de vídeo, que seram usados na frente e no final do vídeo)<br>
&nbsp;•Nomes_arquivos&nbsp;(Salva os nome dos arquivos .mp4 da pasta /videos em nome_dos_arquivos.txt<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;esse arquivo contem os nomes em ordem alfabetica tendo o (intro)1.mp4 primeiro e (fim)z.mp4 em ultimo)<br>
&nbsp;•Unir_videos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(Unifica todos esses vídeos na ordem e gera o output.mp4, mantendo o aspect ratio original individualmente)<br>
&nbsp;•Apagar_arquivos&nbsp;(Apaga dos os arquivos da pasta /videos)<br>
  <br>
  
Print's
---------  
<img width="300" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Coub_Mass_Download/main/1.png">
<br>Botão cosole<br>
<img width="750" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Coub_Mass_Download/main/2.png">
<br>

Depêndencia 
---------  
  •Newtonsoft.Json https://www.nuget.org/packages/Newtonsoft.Json/
<br><br><br>
  
Observações
---------  
O arquivo ffmpeg tem que estar na mesma pasta do Coub_Mass_Download.exe, juntamente com todos os outros arquivos.
<br> Para funcionar é necessario baixar todo o conteudo da pasta: [DOWNLOAD](https://github.com/DanielSvoboda/Coub_Mass_Download/tree/main/Download)
<br><br>
Aproximadamente: <br>
Total vídeo = 25 vídeos * Paginas <br>
Tempo total(min) = Total vídeo*<>10/60
<br><br>
Tentei unificar vídeos com quantidade diferentes de fps, porem, mesmo renderizando com formas específicos e parametros de encoding não tive bons resultados para criar um arquivo compativel da intro.mp4 e fim.mp4, tentei parametros diferentes no ffmpeg tambem sem exito. Então encodei a 'intro' e 'fim' usando a propria função Unir_videos, no nome_dos_arquivos.txt inclui apenas o intro.mp4 e repeti o processo com o fim.mp4, gerando o output.mp4 desse unico arquivo que renomeie para o nome anterior, e assim ele ficou igual aos demais que são baixados do coub e não tem problemas de desincronia dos frames do audio e do vídeo.
<br><b>
Comando ffmpeg da função Unir_vídeos:<br>
ffmpeg -safe 0 -f concat -i videos/nome_dos_arquivos.txt -vf scale=iw*min(1280/iw\,720/ih):ih*min(1280/iw\,720/ih),pad=1280:720:(1280-iw*min(1280/iw\,720/ih))/2:(720-ih*min(1280/iw\,720/ih))/2 output.mp4";
<br><br><br>



FFmpeg
---------  
- Esse programa usa o [FFmpeg](http://ffmpeg.org), uma estrutura de multimídia gratuita que é licenciada sob a [LGPLv2.1 license](http://www.gnu.org/licenses/old-licenses/lgpl-2.1.html)  contendo vários codecs de áudio e vídeo, suportando tarefas de muxing, demuxing e transcodificação em muitos formatos de mídia.

This is a FFmpeg Win32 static build by Kyle Schwarz.<br>
<br>
Zeranoe's FFmpeg Builds Home Page: <http://ffmpeg.zeranoe.com/builds/><br>
<br>
This build was compiled on: , at: 22:01:02<br>
<br>
FFmpeg version: 2014-02-04 git-e708424<br>
  libavutil      52. 63.100 / 52. 63.100<br>
  libavcodec     55. 49.101 / 55. 49.101<br>
  libavformat    55. 29.101 / 55. 29.101<br>
  libavdevice    55.  7.100 / 55.  7.100<br>
  libavfilter     4.  1.102 /  4.  1.102<br>
  libswscale      2.  5.101 /  2.  5.101<br>
  libswresample   0. 17.104 /  0. 17.104<br>
  libpostproc    52.  3.100 / 52.  3.100<br>
<br>
This FFmpeg build was configured with:<br>
  --enable-gpl<br>
  --enable-version3<br>
  --disable-w32threads<br>
  --enable-avisynth<br>
  --enable-bzlib<br>
  --enable-fontconfig<br>
  --enable-frei0r<br>
  --enable-gnutls<br>
  --enable-iconv<br>
  --enable-libass<br>
  --enable-libbluray<br>
  --enable-libcaca<br>
  --enable-libfreetype<br>
  --enable-libgsm<br>
  --enable-libilbc<br>
  --enable-libmodplug<br>
  --enable-libmp3lame<br>
  --enable-libopencore-amrnb<br>
  --enable-libopencore-amrwb<br>
  --enable-libopenjpeg<br>
  --enable-libopus<br>
  --enable-librtmp<br>
  --enable-libschroedinger<br>
  --enable-libsoxr<br>
  --enable-libspeex<br>
  --enable-libtheora<br>
  --enable-libtwolame<br>
  --enable-libvidstab<br>
  --enable-libvo-aacenc<br>
  --enable-libvo-amrwbenc<br>
  --enable-libvorbis<br>
  --enable-libvpx<br>
  --enable-libwavpack<br>
  --enable-libx264<br>
  --enable-libxavs<br>
  --enable-libxvid<br>
  --enable-zlib<br>
<br><br>
This build was compiled with the following external libraries:<br>
  bzip2 1.0.6 <http://bzip.org/><br>
  Fontconfig 2.10.95 <http://freedesktop.org/wiki/Software/fontconfig><br>
  Frei0r 20130909-git-10d8360 <http://frei0r.dyne.org/><br>
  GnuTLS 3.2.8.1 <http://gnutls.org/><br>
  libiconv 1.14 <http://gnu.org/software/libiconv/><br>
  libass 0.10.2 <http://code.google.com/p/libass/><br>
  libbluray 0.5.0 <http://videolan.org/developers/libbluray.html><br>
  libcaca 0.99.beta18 <http://caca.zoy.org/wiki/libcaca><br>
  FreeType 2.5.2 <http://freetype.sourceforge.net/><br>
  GSM 1.0.13-4 <http://packages.debian.org/source/squeeze/libgsm><br>
  iLBC 20120913-git-b5f9b10 <https://github.com/dekkers/libilbc/><br>
  Modplug-XMMS 0.8.8.4 <http://modplug-xmms.sourceforge.net/><br>
  LAME 3.99.5 <http://lame.sourceforge.net/><br>
  OpenCORE AMR 0.1.3 <http://sourceforge.net/projects/opencore-amr/><br>
  OpenJPEG 1.5.1 <http://www.openjpeg.org/><br>
  Opus 1.1 <http://opus-codec.org/><br>
  RTMPDump 20131205-git-dc76f0a <http://rtmpdump.mplayerhq.hu/><br>
  Schroedinger 1.0.11 <http://diracvideo.org/><br>
  libsoxr 0.1.1 <http://sourceforge.net/projects/soxr/><br>
  Speex 1.2rc1 <http://speex.org/><br>
  Theora 1.1.1 <http://theora.org/><br>
  TwoLAME 0.3.13 <http://twolame.org/><br>
  vid.stab 0.98 <http://public.hronopik.de/vid.stab/><br>
  VisualOn AAC 0.1.3 <https://github.com/mstorsjo/vo-aacenc><br>
  VisualOn AMR-WB 0.1.2 <https://github.com/mstorsjo/vo-amrwbenc><br>
  Vorbis 1.3.4 <http://vorbis.com/><br>
  vpx 1.3.0 <http://webmproject.org/><br>
  WavPack 4.70.0 <http://wavpack.com/><br>
  x264 20140121-git-956c8d8 <http://videolan.org/developers/x264.html><br>
  XAVS svn-r55 <http://xavs.sourceforge.net/><br>
  Xvid 1.3.2 <http://xvid.org/><br>
  zlib 1.2.8 <http://zlib.net/><br>
<br><br>
The source code for this FFmpeg build can be found at: <http://ffmpeg.zeranoe.com/builds/source/><br>
This build was compiled on Debian jessie/sid (64-bit): <http://www.debian.org/><br>
GCC 4.8.2 was used to compile this FFmpeg build: <http://gcc.gnu.org/><br>
This build was compiled using the MinGW-w64 toolchain: <http://mingw-w64.sourceforge.net/><br>
