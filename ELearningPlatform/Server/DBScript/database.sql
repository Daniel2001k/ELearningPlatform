CREATE TABLE "public.Language" (
	"Id" serial NOT NULL,
	"Name" varchar NOT NULL,
	CONSTRAINT "Language_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Course" (
	"Id" serial NOT NULL,
	"TutorId" integer NOT NULL,
	"LanguageId" integer NOT NULL,
	"LevelId" integer NOT NULL,
	CONSTRAINT "Course_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Lesson" (
	"Id" serial NOT NULL,
	"CourseId" integer NOT NULL,
	"TaskId" integer NOT NULL,
	"Order" integer NOT NULL,
	"Time" TIMESTAMP NOT NULL,
	CONSTRAINT "Lesson_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.User" (
	"Id" serial NOT NULL,
	"Name" varchar NOT NULL,
	"Surname" varchar NOT NULL,
	"BirthDate" DATE NOT NULL,
	"Pesel" varchar NOT NULL,
	CONSTRAINT "User_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Task" (
	"Id" serial NOT NULL,
	"TaskTypeId" integer NOT NULL,
	CONSTRAINT "Task_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.TaskType" (
	"Id" serial NOT NULL,
	"Name" varchar NOT NULL,
	CONSTRAINT "TaskType_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.CurseLevel" (
	"Id" serial NOT NULL,
	"Name" varchar NOT NULL,
	CONSTRAINT "CurseLevel_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Tutor" (
	"Id" serial NOT NULL,
	"UserId" integer NOT NULL,
	CONSTRAINT "Tutor_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Student" (
	"Id" serial NOT NULL,
	"UserId" integer NOT NULL,
	CONSTRAINT "Student_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.CourseStudent" (
	"Id" serial NOT NULL,
	"CourseId" integer NOT NULL,
	"Student" integer NOT NULL,
	CONSTRAINT "CourseStudent_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);




ALTER TABLE "Course" ADD CONSTRAINT "Course_fk0" FOREIGN KEY ("TutorId") REFERENCES "Tutor"("Id");
ALTER TABLE "Course" ADD CONSTRAINT "Course_fk1" FOREIGN KEY ("LanguageId") REFERENCES "Language"("Id");
ALTER TABLE "Course" ADD CONSTRAINT "Course_fk2" FOREIGN KEY ("LevelId") REFERENCES "CurseLevel"("Id");

ALTER TABLE "Lesson" ADD CONSTRAINT "Lesson_fk0" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id");
ALTER TABLE "Lesson" ADD CONSTRAINT "Lesson_fk1" FOREIGN KEY ("TaskId") REFERENCES "Task"("Id");


ALTER TABLE "Task" ADD CONSTRAINT "Task_fk0" FOREIGN KEY ("TaskTypeId") REFERENCES "TaskType"("Id");



ALTER TABLE "Tutor" ADD CONSTRAINT "Tutor_fk0" FOREIGN KEY ("UserId") REFERENCES "User"("Id");

ALTER TABLE "Student" ADD CONSTRAINT "Student_fk0" FOREIGN KEY ("UserId") REFERENCES "User"("Id");

ALTER TABLE "CourseStudent" ADD CONSTRAINT "CourseStudent_fk0" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id");
ALTER TABLE "CourseStudent" ADD CONSTRAINT "CourseStudent_fk1" FOREIGN KEY ("Student") REFERENCES "Student"("Id");











