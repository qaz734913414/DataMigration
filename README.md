大数据学习路线
===
## 前言
> 要从事计算机行业的工作，不管是什么工作，开发、测试、还是算法等，都是要有一门自己比较熟练的编程语言，编程语言可以是C语言、Java、C++等，只要是和你后续工作所相关的就可以（后续用到其他语言的话，你有一门语言基础了，学起来就快了）。一般初学者入门语言大多都会选择Java、C语言、C++或者Python，而且现在网上有很多好的视频，可以供初学者学习使用。关于学习视频或者资料的选择，知乎或者百度等都有很多讲解了，也可以跟师兄师姐咨询，这样可以少走很多弯路，当然，有人说，走一些弯路总是有好处的，但是我这里说的弯路不是说不犯错误，不调bug，而是指学习资料以及一些知识点的偏重点，这样可以尽量节约一部分时间，刚开始时，总会有点迷，而且当你真正投入进去学习时，会发现时间总是不够用。  
 下面就说一下我自己从Java开发到大数据开发的曲折学习之路（狗头保命.jpg）。  
 因为我现在是做大数据相关的工作了，所以Java后端涉及到的一些SSM框架等知识点我就不介绍了，毕竟后续一段时间也没有做了。自己看过的大数据学习相关的视频+资料大概是200G-300G吧，从Linux->Hadoop->。。。->Spark->项目，还有就是一些面试文档，面经等。一些视频看了两遍或者更多，跟着学，跟着敲代码，做项目，准备面试。  
 涉及到需要学习的东西包括：JavaSE，数据结构与算法（计算机行业必备），MySQL，Redis，ES（数据库这些可以看项目，也可以自己熟练一两个），Linux，Shell（这个可以后期补），Hadoop，Zookeeper，Hive，Flume，Kafka，HBase，Scala（Spark是Scala写的，会Scala做相关的项目会更容易入手），Spark，Flink（这个是找工作时有面试官问过几次liao不liao解，所以找完工作才开始接触学习），相关项目。  

## 编程语言阶段学习
 如果是零基础的话，建议还是从视频开始入门比较好，毕竟一上来就看教材，这样有些代码的来龙去脉可能不是很了解。如果是有一些编程语言基础的话，从视频开始也会更简单，一些for、while循环你都知道了，学起来也会快很多。    
 JavaSE我是选择的黑马刘意的为主，因为刚刚开始学Java看过一本从《Java从入门到精通》，没什么感觉，后续又在看了慕课网的Java初级视频，还是没感觉出来啥（当时就有点怀疑自己了。。。），可能有点没进入状态。  
 还好后续找了黑马刘意老师的JavaSE视频（我是看的2015年版本，那时候19版还没出），觉得他讲的真的是很好很详细，每个知识点都会有例子，也都会带你敲代码，做测试，可能前面有C语言基础，然后也看过Java的一些语法，所以学起来还是比较顺利，后面的IO流、多线程等知识点时，也有看书看博客，或者看看其他老师的课程，讲解的可能自己比较容易接受就可以，反正都是多尝试（下面会给出视频链接），尽量懂一些，后续可以回头来复习。JavaSE相关的视频，先看一遍，后续有时间建议再看一遍，而且这些经典的视频，看两遍真的是享受。  
 如果有一定基础了的，JavaSE前面七八天的视频可以加速看，但是不懂的一定要停下开仔细想想，零基础的还是尽量不要加速吧，慢慢来稳些。后面的视频建议还是跟着视频来，尽量不要加速，代码尽量都敲一敲，第一遍基本上一个月到一个半月可以结束。  
 JavaSE可以说是很基础也很重要的东西，主要重点包括**面向对象、集合（List、Map等），IO流，String/StringBuilder/StringBuffer、反射、多线程**，这些最好是都要熟悉一些，面试也是重点。  
 JavaSE之后，如果你是要走前端或后端开发路线的话，可以跟着一些网上的视频继续学习，这里我就不多做介绍了。  
**=========================分割线，Scala可以后续Spark阶段再接触学习========================**  
  Scala的学习，Scala是一门多范式 (multi-paradigm) 的编程语言，Scala支持面向对象和函数式编程，最主要的是后续Spark的内容需要用到Scala，所以前面学习了JavaSE，到Spark学习之前，再把Scala学习一波，美滋滋，而且Scala可以和Java进行无缝对接，混合使用，更是爽歪歪。后续Spark学习时基本都是用的Scala，也可能是和Java结合使用，所以Spark之前建议还是先学一波Scala，而且Scala用起来真是很舒服（wordcount一行代码搞定），适合迭代式计算，对数据处理有很大帮助，不过Scala看代码很容易看懂，但是学起来还是挺难的，比如样例类（case class）用起来真是nice，但是隐式转换学起来就相对比较难。学习Scala的建议：**1. 学习scala 特有的语法，2. 搞清楚scala和java区别，3. 了解如何规范的使用scala**。Scala对学习Spark是很重要的（后面Flink也是要用），虽然现在很多公司还是用Java开发比较多，而且Spark是Scala写的，如果要读源码，会Scala还是很重要的（至少要看得懂代码）。  
 Scala主要重点包括：**隐式转换和隐式参数、模式匹配、函数式编程**。这里我看的是尚硅谷韩老师的Scala视频，韩老师讲的真的很不错，五星推荐，哈哈。  
 也许有人会觉得Python也是需要的，但是学习阶段，可能用Java还是比较多，面试也基本都是问Java相关的内容，所以Python后续工作会用到的话，再看看Python的内容吧。  

#### 视频链接
 [刘意JavaSE（2015版）](https://www.bilibili.com/video/av61085712?spm_id_from=333.788.b_765f64657363.1)  
 [刘意JavaSE（2019-IDEA版）](https://www.bilibili.com/video/av33742840?from=search&seid=133977217265304586)  
 [毕向东JavaSE](https://www.bilibili.com/video/av33655233?from=search&seid=2781407421774837041)  
 [尚硅谷康师傅JavaSE（2019-IDEA版）](https://www.bilibili.com/video/av67742669?from=search&seid=10956810156295689049)  
 [尚硅谷韩老师Scala](https://www.bilibili.com/video/av39126512?from=search&seid=3818888777220362127)  

## 大数据框架阶段学习
 大数据这方面的知识点自己可以说真的是从零开始的，刚刚开始学那会Linux基本都没用过，心里那个虚啊，而且时间也紧迫，想起来都是一把辛酸泪。  
 刚刚开始学的时候，看了厦门大学林子雨的《 大数据技术原理与应用》课程，可能这个课程是面对上课的，所以看了一些，感觉对自己帮助不是很大（并不是说课程不好，可能不太适合自己，如果是要了解理论知识，很透彻，但是俺时间紧迫啊），所以就继续在网上找视频，然后发现尚硅谷的培训视频很多人去参加，而且知识点也很齐全，大数据相关组件都有讲课，还有一些项目比较好，所以就找了它相关的视频，看的是2018年的，所以视频不算旧。  
 来一张推荐系统架构的图，先看看  
<img src="https://github.com/Dr11ft/BigDataGuide/blob/master/Pics/%E6%8E%A8%E8%8D%90%E7%B3%BB%E7%BB%9F%E6%9E%B6%E6%9E%84%E5%9B%BE.jpg"/> 
 一般来说，Flume+Kafka对数据进行采集聚合传输，一方面Spark对实时数据进行处理，传输给相应的数据处理模块（比如实时数据处理的算法模块，Spark也有提供常见的机器学习算法的程序库），另一方面采集的数据也可以放入数据库（HBase、MongoDB等）中，后续MapReduce对离线数据进行离线处理，数据处理完毕用于后续的使用，数据采集处理的流程大概就是这样。如果是推荐系统，实时推荐会给用户产生实时的推荐结果，让用户进行查阅选择，比如你在界面浏览了或者看了新的物品，然后刷新下界面，可能给你展示的东西就有一些变成跟你刚刚浏览的相关了。离线推荐的话主要是对离线数据进行处理，为物品或种类做出相似的推荐，如果后续用户搜索相应的物品时，给用户展示相应的产品，比如你在淘宝搜索大数据书籍，淘宝会给你推荐相关的书籍，这就算是为大数据书籍产生的推荐结果。  
<img src="https://github.com/Dr11ft/BigDataGuide/blob/master/Pics/%E6%B7%98%E5%AE%9D.png"/> 
 大数据学习路线：Linux -> Hadoop -> Zookeeper -> Hive -> Flume -> Kafka -> HBase -> Scala -> Spark -> 项目 - > Flink（ 如果需要Storm，在Spark前面学习，云盘中也加进去了）  
<p align="center">
<img src="https://github.com/Dr11ft/BigDataGuide/blob/master/Pics/%E5%A4%A7%E6%95%B0%E6%8D%AE%E6%A1%86%E6%9E%B6.png"/>  
<p align="center">
</p>
</p>

### 一、Linux（基本操作）
 一般我们使用的都是虚拟机来进行操作，所以要安装VM（ Virtual Machine），我使用的是CentOS，所以VM和CentOS都要跟着安装好，跟着视频操作，一定要动手实践，将一些Linux基本命令熟练掌握，一些VIM编辑器的命令也要会用，做相应的一些配置，使用SecureCRT来做远程登录操作（也可以使用其他的，自己顺手就行）。再强调一遍，基本操作命令尽量熟练一点，如果一下记不住，打印一些常用的，自己看看，多用多实践，慢慢就会用了。还有一些软件包的下载安装卸载等，跟着操作一遍，熟悉下，后续都会使用，Shell编程可以后续补。  
#### 视频：
 [如果想了解下shell（后面乌班图的可以选择不看）](https://www.bilibili.com/video/av21303002?p=9)  
 [没有shell讲解](https://www.bilibili.com/video/av68267149?p=5)

### 二、Hadoop（重点中的重点）
 Hadoop是一个分布式系统基础框架，用于主要解决海量数据的存储和海量数据的分析计算问题，也可以说Hadoop是后续整个集群环境的基础，很多框架的使用都是会依赖于Hadoop。主要是由HDFS、MapReduce、YARN组成。这个部分安装Hadoop，Hadoop的三个主要组成部分是重点，对他们的概念要理解出来，知道他们是做什么的，搭建集群环境，伪分布式模式和完全分布式模式的搭建，重要的是完全分布式的搭建，这些部分一定要自己动手实践，自己搭建集群，仔细仔细再仔细，Hadoop的NameNode，DataNode，YARN的启动关闭命令一定要知道，以及他们的启动关闭顺序要记住，不要搞混。后续视频会有一些案例操作，跟着写代码，做测试，把基本环境都配置好，后续这个集群（完全分布式需要三台虚拟机）要一直使用。  
#### 视频：  
 我开始看过的版本：这个版本b站已经失效了，不过云盘中有给出链接  
 [第二个看过的版本](https://www.bilibili.com/video/av32081351?p=1)  
 [2019版本](https://www.bilibili.com/video/av64039568?from=search&seid=1820891664356324892)  

### 三、Zookeeper
 Zookeeper是一个开源的分布式的，为分布式应用提供协调服务的Apache项目。分布式安装ZK，对ZK有一定的了解就可以了，了解它的应用场景，以及内部原理，跟着做一些操作，基本上有一些了解即可。  
#### 视频：  
 [我看过的版本](https://www.bilibili.com/video/av53962808?from=search&seid=14867728339471861924)  
 [尚硅谷周洋版本（听说挺好）](https://www.bilibili.com/video/av64765091?from=search&seid=14867728339471861924)  
 [2019版本](https://www.bilibili.com/video/av32093417?from=search&seid=14867728339471861924)  

### 四、Hive（重点）
 Hive是基于Hadoop的数据仓库工具，可以将结构化的数据文件映射为一张表，并提供类SQL查询功能。Hive的安装，它的数据类型，以及它的数据定义、数据操作有较好的了解，怎么操作表（创建表、删除表，创建什么类型的表，他们有什么不同），怎么操作数据（加载数据，下载数据，对不同的表进行数据操作），对数据的查询一定要进行实践操作，以及对压缩方式和存储格式要有一些了解，用到时不懂也可以去查，最好是能理解清楚。这部分有什么面试可能会问，所以视频后续的面试讲解可以看看，理解清楚。  
#### 视频：
 [我开始看过的版本](https://www.bilibili.com/video/av76061713?from=search&seid=6080018633047350271)  
 [第二个看过的版本](https://www.bilibili.com/video/av32097088?from=search&seid=14922409626561581253)  
 [2019版本](https://www.bilibili.com/video/av65556024?from=search&seid=14922409626561581253)  

### 五、Flume
 Flume是一个高可用的，高可靠的，分布式的海量日志采集、聚合和传输的系统。对于Flume，对它的组成架构，以及对Flume Agent的内部原理要理解清楚，Source、Channel、Sink一定要知道它们的各种类型以及作用，有哪些拓扑结构是常见常用的，例如一对一，单Source、多Channel、多Sink等，它们有什么作用，要理解清楚。还有一个重点，就是对Flume的配置文件一定要了解清楚，不懂的可以上官网查看案例，对于不同的情况，它的配置文件要做相应的修改，才能对数据进行采集处理，视频中的实践案例一定要跟着做。  
#### 视频：
 [我开始看过的版本](https://www.bilibili.com/video/av66126320?from=search&seid=4743678003250939296)  
 [第二个看过的版本](https://www.bilibili.com/video/av68376629?from=search&seid=15081053946655972416)  
 [2019版本](https://www.bilibili.com/video/av65541678?from=search&seid=13455141829682550307)  

### 六、Kafka（重点）
 Kafka是一个分布式消息队列，用来缓存数据的。比如说实时计算中可以通过Flume+Kafka对数据进行采集处理之后，Spark Streaming再使用Kafka相应的Topic中的数据，用于后续的计算使用。对于Kafka，要理解Kafka的架构，什么是Kafka，为什么需要Kafka，应用场景。基本的命令行操作要掌握，比如怎么创建删除Topic，怎么通过生产者生成数据，消费者怎么消费数据等基本操作，官网也是有一些案例可以查阅的。  
#### 视频：
 [我看过的版本](https://www.bilibili.com/video/av49920938?from=search&seid=12535568434906893507)  
 [2019版本](https://www.bilibili.com/video/av65544753?from=search&seid=12535568434906893507)  

### 七、HBase（重点）
 HBase是一个分布式的、基于列存储的开源数据库。HBase适合存储PB级别的海量数据，也可以说HBase是很适合大数据的存储的，它是基于列式存储数据的，列族下面可以有非常多的列，列族在创建表的时候就必须指定。所以对HBase的数据结构要有一定的理解，特别是RowKey的设计部分（因为面试被问到过，咳咳，所以点一下），对于它的原理要了解，一些基本操作也要都会，比如创建表，对表的操作，基本的API使用等。  
#### 视频：
 [我看过的版本](https://www.bilibili.com/video/av35356127?from=search&seid=759279005217475156)  
 [2019版本](https://www.bilibili.com/video/av65548392?from=search&seid=759279005217475156)  

### 八、Spark
 Spark是快速、易用、通用的大数据分析引擎。一说到Spark，就有一种哪哪都是重点感觉，哈哈。  
 Spark的组成可以看下图  
<img src="https://github.com/Dr11ft/BigDataGuide/blob/master/Pics/Spark%E7%BB%84%E6%88%90.png"/>  
 Spark是基于内存计算的，对于数据的处理速度要比MapReduce快很多很多，而且数据挖掘这些都是要对数据做迭代式计算，MapReduce对数据的处理方式也不适合，而Spark是可以进行迭代式计算，很适合数据挖掘等场景。Spark的Spark SQL能够对结构化数据进行处理，Spark SQL的DataFrame或DataSet可以作为分布式SQL查询引擎的作用，可以直接使用Hive上的表，对数据进行处理。Spark Streaming主要用于对应用场景中的实时流数据进行处理，支持多种数据源，DStream是Spark Streaming的基础抽象，由一系列RDD组成，每个RDD中存放着一定时间段的数据，再对数据进行处理，而且是基于内存计算，速度快，所以很适合实时数据的处理。Spark MLlib提供常见的机器学习(ML)功能的程序库。包括分类、回归、聚类、协同过滤等，还提供了模型评估、数据 导入等额外的支持功能。对Spark的核心组件、部署模式（主要是Standalone模式和YARN模式）、通讯架构、任务调度要有一定了解（面试问到了可以说一波），Spark Shuffle要好好理解，还有内存管理要知道，对Spark的内核原理一定要好好理解，不仅面试可能要用，以后工作也是有帮助的。    
#### 视频：
 [我开始看过的版本](https://www.bilibili.com/video/av49309801?p=7)  
 [第二个看过的版本](https://www.bilibili.com/video/av51485821?from=search&seid=6784944762132058487)  
 [2019版本](https://www.bilibili.com/video/av62992342?from=search&seid=6784944762132058487) 

### 九、Flink（重点中的重点）
 Flink是一个框架和分布式处理引擎，用于对无界（有开始无结束）和有界（有开始有结束）数据流进行有状态计算。现在主要是阿里这种大公司使用的比较多，中国很多公司使用的还是Spark居多，而且Flink基本上都是和Spark很多功能大体上一样的，但是以后Flink和Spark孰强孰弱还有待时间的考验，不过Flink近几年越来越火了这是事实，所以如果有时间有精力的话，可以学一学Flink相关的内容也是很不错的。Spark和Flink主要都是在数据处理方面应用，在数据处理方面的话，离线数据处理：Flink暂时比不上Spark，Spark SQL优点在于可以和Hive进行无缝连接，Spark SQL可以直接使用Hive中的表；Flink暂时做不到这一步，因为官方不支持这一操作，Flink只能将数据读取成自己的表，不能直接使用Hive中的表。对于实时数据的处理：Flink和Spark可以说是平分秋色吧，而且Flink是以事件为驱动对数据进行处理，而Spark是以时间为驱动对数据进行处理，在一些应用场景中，也许Flink的效果比Spark的效果还要好些，因为Flink对数据更加的敏感。比如一秒钟如果触发了成千上万个事件，那么时间驱动型就很难对数据做细致的计算，而事件驱动型可以以事件为单位，一个个事件进行处理，相比而言延迟更低，处理效果更好。还是那句话，虽然现在使用的公司较少，但是有时间接触学习下，也是没有坏处的。
#### 视频：
 [我看的版本（基础+项目）](https://www.bilibili.com/video/av73133501?from=search&seid=4014046399897085512)  

## 项目阶段
 其实尚硅谷的视频里面有很多大数据相关的项目，而且都是文档配代码的，学习期间可以跟着视频做两到三个项目，自己理清思路，把项目理解透彻，还是可以学到很多东西的。  
 根据自己情况，选择两到三个项目重点跟着做，理解透彻一点  
### 大数据项目实战
 尚硅谷的视频里面有很多大数据相关的项目，而且都是文档配代码的，学习期间可以跟着视频做两到三个项目，自己理清思路，把项目理解透彻，还是可以学到很多东西的。**根据自己情况，选择两到三个项目重点跟着做，理解透彻一点。相关项目文档资料我已经放到网盘，公众号回复相应关键字获取领取方式。**  
 相关项目、涉及技术框架及其B站链接（B站链接间知乎文章。，主要是为了有些小伙伴网盘速度限制，这样就下载文档资料即可）  

1）[YouTube项目：Hive](https://www.bilibili.com/video/av46279488?from=search&seid=9082792700815539199)  
2）[微博项目：HBase](https://www.bilibili.com/video/av47966656?from=search&seid=15571841572335097117)  
3）[电商数据分析平台：Spark](https://www.bilibili.com/video/av51501619?p=25)  
4）[电信客服系统：Hadoop](https://www.bilibili.com/video/av39312730?from=search&seid=9082792700815539199)  
5）[滴滴系统：Kafka+Storm](https://www.bilibili.com/video/av47297403?from=search&seid=2895912804952398963)  
6）[大数据离线平台：Hadoop+Flume+Hive+HBase](https://www.bilibili.com/video/av46287611?from=search&seid=9082792700815539199)  
7）[电商数仓项目：Hadoop+Zookeeper+Hive+Flume+Kafka+Spark](https://www.bilibili.com/video/av55357971?from=search&seid=13797269418701982102)  
8）[电商推荐系统（类似于电影推荐系统）：Hadoop+ZK+Flume+Kafka+Spark+Redis+MongoDB](https://www.bilibili.com/video/av52027052?p=2)  
9）[电影推荐系统（2019版也有个一样的电影推荐系统，代码应该类似）：Hadoop+ZK+Flume+Kafka+Spark+Redis+MongoDB+ElasticSearch](https://www.bilibili.com/video/av47281318?from=search&seid=13797269418701982102)  
 [2019版](https://www.bilibili.com/video/BV1CJ411Q7L9?p=63)  
10）基于阿里云搭建数据仓库（离线、实时）：ECS（日志生产服务器）+Flume+DataHub +MaxCompute/DataWorks +RDS（业务数据）+QuickBI  
 [离线](https://www.bilibili.com/video/BV1QJ411k76B?from=search&seid=5345818275548812087)  
 [实时](https://www.bilibili.com/video/BV1pJ411r7Yk?from=search&seid=5345818275548812087)  
11）机器学习和推荐系统：项目讲解为上面的电影推荐系统类似  
12）[实时项目（电商数仓实时）：Hive+Kafka+Redis+Nginx+ElasticSearch+Canal](https://www.bilibili.com/video/BV1kA41147bS?from=search&seid=12616316689401784017)  
13）手机APP信息统计：Hadoop+ZK+Flume+Kafka+Hive+HBase+Spark（有两个不同版本，详细看项目文档）  
 [旧版本](https://www.bilibili.com/video/av47307345?from=search&seid=13797269418701982102)  
 [新版本](https://www.bilibili.com/video/av51501685?from=search&seid=13797269418701982102)  
14）新闻大数据实时分析可视化系统（私人提供，参考云盘）：Hadoop+Zookeeper+Flume+Kafka+Hive+HBase+Spark+Echarts+Hue+MySQL  
15）[在线教育项目：Hadoop+Flume+Kafka+Hive+MySQL+Spark](https://www.bilibili.com/video/av63729562?p=13)  
16）[基于Flink的电商用户行为数据分析：Kafka+Flink](https://www.bilibili.com/video/BV1gJ411Q72x?from=search&seid=5800841516085262679)  

## 机器学习
 大数据岗位中也是有对算法要求比较高的，就是数据挖掘岗位，相对来说，对机器学习算法有一定要求。这里就不介绍了，有时间可以自己学习机器学习相关的内容，如果你有机器学习的基础，那自然是更好了。  
 下面是我自己收集的一些资料，有需要的可以看看  
 [机器学习算法学习资料](https://zhuanlan.zhihu.com/p/92760753)  

## 书籍
 书籍部分直接云盘链接保存即可，这里我放两张Java开发和大数据开发我自己的书单（很多，路漫漫，吾将上下而求索~）    
 Java后端书架：  
<p align="center">
<img src="https://github.com/Dr11ft/BigDataGuide/blob/master/Pics/Java%E5%90%8E%E7%AB%AF%E4%B9%A6%E6%9E%B6(1).png"/>  
<p align="center">
</p>
</p>  
 大数据书架：  
<p align="center">
<img src="https://github.com/Dr11ft/BigDataGuide/blob/master/Pics/%E5%A4%A7%E6%95%B0%E6%8D%AE%E4%B9%A6%E6%9E%B6(1).png"/>  
<p align="center">
</p>
</p>  
 大概就这些，看完就需要很久了，大部分我也是需要的时候看相应的部分，所以有时间可以好好看下，不然就需要哪一部分看哪一部分，有助于学习即可。  

## 最后
 大数据开发也是需要编程基础的，并不是学会使用这些框架怎么样就可以了，所以对于**编程语言，数据结构与算法，计算机网络这些基础**也是要的，这些基础知识也有助于自己以后的发展，如果是应届生校招的话，面试基本上都是JavaSE和数据结构与算法等的知识点，还有大数据组件相关的知识点，以及对项目的理解，这些都是要自己面试前准备好的，多看面经，多找面试题看，面几次，心里有谱了，后续面试就好了。  
 不管是从事什么样的计算机相关的岗位，编程都是很重要的，**数据结构与算法特别重要**，还有就是**leetcode等编程网站刷题**，提升自己的编程思维，后续笔试面试都要要的。  
 **要将一行行代码看做一叠叠rmb，但是一行行代码能不能转换成一叠叠rmb，自己就一定要：坚持，多敲代码；多敲代码，坚持；坚持**。  
 以上纯属个人总结，也许有理解不是很好的地方，每个人都有自己的学习方法，不喜勿喷，谢谢~  


# 跨库数据同步工具

跨库数据迁移基于NewLife.XCode开发的工具，支持任意数据进行数据之间的迁移和同步

![测试1](/Doc/1.jpg)

![测试2](/Doc/2.jpg)

![测试3](/Doc/3.jpg)

![测试4](/Doc/4.jpg)
