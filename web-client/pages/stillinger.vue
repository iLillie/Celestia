<template>
  <main class="p-8 grid main gap-8 content-start overflow-y-auto max-w-min">
    <AdvertItem v-for="advert in adverts" :advert="advert" :key="advert.id"></AdvertItem>
  </main>
</template>

<style>
body {
  background-color: #F7F7F8;
}

.main {
  justify-items: start;
  justify-content: start;
  grid-template-columns: 1fr 1fr 1fr;
}
</style>

<script lang="ts">
import Vue from 'vue'

export default Vue.extend({
  name: 'Stillinger',
  async asyncData({ $axios }) {
    let advertsFinn:any = {
      "docs": [
        {
          "type": "job",
          "ad_id": 257250686,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du jobbe med CI/CD-plattform for styringssystemer for IP-nett og tjenester som er kritisk for samfunnet?",
          "location": "Fornebu",
          "flags": [],
          "timestamp": 1651755660000,
          "coordinates": {
            "lat": 59.8998,
            "lon": 10.62909
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/550336865/20220328/62eeb9c5-afc2-4aa0-aefb-3894d378e2a8",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/550336865/20220328/62eeb9c5-afc2-4aa0-aefb-3894d378e2a8"
          },
          "job_title": "Linux CI/CD Automation Engineer",
          "deadline": 1653775200000,
          "published": 1651755660000,
          "company_name": "Telenor Norge AS",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/550336865/20220328/62eeb9c5-afc2-4aa0-aefb-3894d378e2a8",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/550336865/20220328/62eeb9c5-afc2-4aa0-aefb-3894d378e2a8"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257250686"
        },
        {
          "type": "job",
          "ad_id": 257233137,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "We're looking for developers with a hacker mentality",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651754940000,
          "coordinates": {
            "lat": 59.91292,
            "lon": 10.73846
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/7/257/233/137_1745505565.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/7/257/233/137_1745505565.png"
          },
          "job_title": "Hacker",
          "published": 1651754940000,
          "company_name": "Promon",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/7/257/233/137_1745505565.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/7/257/233/137_1745505565.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257233137"
        },
        {
          "type": "job",
          "ad_id": 257240109,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vi trenger deg som kan se skogen, mens vi andre bare ser trær!",
          "location": "Haugesund",
          "flags": [],
          "timestamp": 1651754820000,
          "coordinates": {
            "lat": 59.39483,
            "lon": 5.30458
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/9/257/240/109_1213277670.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/9/257/240/109_1213277670.jpg"
          },
          "job_title": "UX/UI Developer",
          "published": 1651754820000,
          "company_name": "CGI",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/9/257/240/109_1213277670.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/9/257/240/109_1213277670.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257240109"
        },
        {
          "type": "job",
          "ad_id": 257243461,
          "main_search_key": "SEARCH_ID_JOB_PARTTIME",
          "heading": "Vi søker utvikler på deltid til Enable!",
          "location": "Trondheim",
          "flags": [],
          "timestamp": 1651752180000,
          "coordinates": {
            "lat": 63.40179,
            "lon": 10.40703
          },
          "ad_type": 43,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/171/016/046/1_1396200245.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/171/016/046/1_1396200245.png"
          },
          "job_title": "Utvikler",
          "deadline": 1653948000000,
          "published": 1651752180000,
          "company_name": "Academic Work",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/171/016/046/1_1396200245.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/171/016/046/1_1396200245.png"
          },
          "ad_link": "https://www.finn.no/job/parttime/ad.html?finnkode=257243461"
        },
        {
          "type": "job",
          "ad_id": 257238991,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Senior Software Developer",
          "location": "Ålesund",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651751940000,
          "coordinates": {
            "lat": 62.47406,
            "lon": 6.24459
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/1/257/238/991_1199608038.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/1/257/238/991_1199608038.png"
          },
          "job_title": "Senior Utvikler",
          "published": 1651751940000,
          "company_name": "Solwr AS",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/1/257/238/991_1199608038.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/1/257/238/991_1199608038.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257238991"
        },
        {
          "type": "job",
          "ad_id": 257242475,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Scrum Mastere, utviklere og arkitekter søkes til vår avdeling Åndalsnes",
          "location": "Åndalsnes",
          "flags": [],
          "timestamp": 1651751400000,
          "coordinates": {
            "lat": 62.564,
            "lon": 7.6861
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/242/475_675583723.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/242/475_675583723.png"
          },
          "job_title": "Scrum Mastere, utviklere og arkitekter søkes til vår avdeling Åndalsnes",
          "deadline": 1654466400000,
          "published": 1651751400000,
          "company_name": "PostNord AS",
          "no_of_positions": 3,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/242/475_675583723.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/242/475_675583723.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257242475"
        },
        {
          "type": "job",
          "ad_id": 257239144,
          "main_search_key": "SEARCH_ID_JOB_MANAGEMENT",
          "heading": "Avdelingsleder Dataintelligens",
          "location": "Stavanger",
          "flags": [],
          "timestamp": 1651749660000,
          "coordinates": {
            "lat": 58.97363,
            "lon": 5.72225
          },
          "ad_type": 44,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/239/144_129583583.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/239/144_129583583.png"
          },
          "job_title": "Avdelingsleder Dataintelligens",
          "deadline": 1653775200000,
          "published": 1651749660000,
          "company_name": "Innovasjon Norge",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/239/144_129583583.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/239/144_129583583.png"
          },
          "ad_link": "https://www.finn.no/job/management/ad.html?finnkode=257239144"
        },
        {
          "type": "job",
          "ad_id": 257237185,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Har du lyst til å bidra til fortsatt høy tillit til valg og demokrati i Norge?",
          "location": "Tønsberg",
          "flags": [],
          "timestamp": 1651748640000,
          "coordinates": {
            "lat": 59.26386,
            "lon": 10.40448
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/8813913/iad_2954542970276168653valgdirektoratet_logo__730.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/8813913/iad_2954542970276168653valgdirektoratet_logo__730.png"
          },
          "job_title": "Systemutviklere - Valgadministrasjonssystemet EVA",
          "deadline": 1653170400000,
          "published": 1651748640000,
          "company_name": "Valgdirektoratet",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/8813913/iad_2954542970276168653valgdirektoratet_logo__730.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/8813913/iad_2954542970276168653valgdirektoratet_logo__730.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257237185"
        },
        {
          "type": "job",
          "ad_id": 257189544,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Are you our new automation engineer?",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651747740000,
          "coordinates": {
            "lat": 59.91292,
            "lon": 10.73846
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/4/257/189/544_91829557.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/4/257/189/544_91829557.png"
          },
          "job_title": "Software developer",
          "published": 1651747740000,
          "company_name": "Promon",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/4/257/189/544_91829557.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/4/257/189/544_91829557.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257189544"
        },
        {
          "type": "job",
          "ad_id": 257234579,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vi er på vei opp i sky. Er du Cloud Ops Engineer'en som kan styrke vårt kjerneteam?",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651747260000,
          "coordinates": {
            "lat": 59.91438,
            "lon": 10.75245
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/9/257/234/579_1767440054.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/9/257/234/579_1767440054.png"
          },
          "job_title": "Cloud Ops Engineer",
          "deadline": 1653170400000,
          "published": 1651747260000,
          "company_name": "Fremtind",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/9/257/234/579_1767440054.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/9/257/234/579_1767440054.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257234579"
        },
        {
          "type": "job",
          "ad_id": 198887559,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du være en del av Norges mest spennende teknologiske lekegrind?",
          "location": "Kråkerøy",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651747200000,
          "coordinates": {
            "lat": 59.21396,
            "lon": 10.92594
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2020/11/vertical-0/18/9/198/887/559_110266318.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2020/11/vertical-0/18/9/198/887/559_110266318.jpg"
          },
          "job_title": "Software utvikler / Ekspert elektronikkutvikler",
          "published": 1651747200000,
          "company_name": "Nxtech AS",
          "no_of_positions": 2,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2020/11/vertical-0/18/9/198/887/559_110266318.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2020/11/vertical-0/18/9/198/887/559_110266318.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=198887559"
        },
        {
          "type": "job",
          "ad_id": 257231304,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du være med i et Data Engineering Team og samtidig bidra til at norsk næringsliv lykkes?",
          "location": "Stavanger",
          "flags": [],
          "timestamp": 1651745580000,
          "coordinates": {
            "lat": 58.97918,
            "lon": 5.7159
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/231/304_22205372.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/231/304_22205372.png"
          },
          "deadline": 1653429600000,
          "published": 1651745580000,
          "company_name": "Innovasjon Norge",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/231/304_22205372.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/4/257/231/304_22205372.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257231304"
        },
        {
          "type": "job",
          "ad_id": 257231111,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du være med i ML teamet og samtidig bidra til at norsk næringsliv lykkes?",
          "location": "Stavanger",
          "flags": [],
          "timestamp": 1651745520000,
          "coordinates": {
            "lat": 58.97918,
            "lon": 5.7159
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/231/111_1707427599.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/231/111_1707427599.png"
          },
          "deadline": 1653429600000,
          "published": 1651745520000,
          "company_name": "Innovasjon Norge",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/231/111_1707427599.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/231/111_1707427599.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257231111"
        },
        {
          "type": "job",
          "ad_id": 257229382,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Ambisjoner om å bli en ettertraktet Java eller .NET-utvikler? Vi investerer i deg!",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651744620000,
          "coordinates": {
            "lat": 59.91432,
            "lon": 10.76356
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/2/257/229/382_1137779317.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/2/257/229/382_1137779317.jpg"
          },
          "job_title": "Java/.NET-utvikler (Graduateprogram)",
          "published": 1651744620000,
          "company_name": "EXPERIS AS",
          "no_of_positions": 30,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/2/257/229/382_1137779317.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/2/257/229/382_1137779317.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257229382"
        },
        {
          "type": "job",
          "ad_id": 257226998,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du jobbe i en etat med et viktig samfunnsoppdrag?",
          "location": "Horten",
          "flags": [],
          "timestamp": 1651743300000,
          "coordinates": {
            "lat": 59.41608,
            "lon": 10.48561
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1623336320/iad_2847496983460934581kriminalomsorgen.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1623336320/iad_2847496983460934581kriminalomsorgen.png"
          },
          "job_title": "Vi søker deg som vil lede og utvikle vår IKT seksjon",
          "deadline": 1653170400000,
          "published": 1651743300000,
          "company_name": "Kriminalomsorgsdirektoratet (KDI)",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1623336320/iad_2847496983460934581kriminalomsorgen.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1623336320/iad_2847496983460934581kriminalomsorgen.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257226998"
        },
        {
          "type": "job",
          "ad_id": 257221406,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Er du snart ferdig med IKT Fagbrev og på jakt etter relevant jobb?",
          "location": "Oslo",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651740720000,
          "coordinates": {
            "lat": 59.91268,
            "lon": 10.74155
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png"
          },
          "job_title": "IKT Fagbrev",
          "published": 1651740720000,
          "company_name": "Hodejakt1",
          "no_of_positions": 5,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257221406"
        },
        {
          "type": "job",
          "ad_id": 257222381,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "UX-designer som digger offentlige tjenester",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651740660000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "UX-designer som digger offentlige tjenester",
          "deadline": 1653170400000,
          "published": 1651740660000,
          "company_name": "UDI",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257222381"
        },
        {
          "type": "job",
          "ad_id": 257222338,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Want to build the next wireless revolution? Notice the acronym UWB!",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651740660000,
          "coordinates": {
            "lat": 59.95405,
            "lon": 10.76508
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/2354665/20210820/201de8ad-893e-4e79-873b-43ac8e390a17",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/2354665/20210820/201de8ad-893e-4e79-873b-43ac8e390a17"
          },
          "job_title": "Software Engineer",
          "deadline": 1655330400000,
          "published": 1651740660000,
          "company_name": "Novelda AS",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/2354665/20210820/201de8ad-893e-4e79-873b-43ac8e390a17",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/2354665/20210820/201de8ad-893e-4e79-873b-43ac8e390a17"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257222338"
        },
        {
          "type": "job",
          "ad_id": 257222025,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Testleder",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651740480000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Testleder",
          "deadline": 1653170400000,
          "published": 1651740480000,
          "company_name": "UDI",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257222025"
        },
        {
          "type": "job",
          "ad_id": 257222011,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du jobbe innen reiseliv og utvikling? Vi søker etter deg som er senior .net utvikler",
          "location": "Bergen",
          "flags": [],
          "timestamp": 1651740480000,
          "coordinates": {
            "lat": 60.39338,
            "lon": 5.31123
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/222/011_1529481001.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/222/011_1529481001.jpg"
          },
          "job_title": "Senior .NET utvikler",
          "published": 1651740480000,
          "company_name": "Fjord Tours AS",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/222/011_1529481001.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/1/257/222/011_1529481001.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257222011"
        },
        {
          "type": "job",
          "ad_id": 257221315,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Senior .Net-utviklere",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651740120000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Senior .Net-utviklere",
          "deadline": 1653170400000,
          "published": 1651740120000,
          "company_name": "UDI",
          "no_of_positions": 10,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257221315"
        },
        {
          "type": "job",
          "ad_id": 257220706,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vi søker to erfarne endringsledere (Change Manager)",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651739820000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Endringsledere (Change Manager)",
          "deadline": 1653170400000,
          "published": 1651739820000,
          "company_name": "UDI",
          "no_of_positions": 2,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257220706"
        },
        {
          "type": "job",
          "ad_id": 257218277,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Data Scientist",
          "location": "Trondheim",
          "flags": [],
          "timestamp": 1651739760000,
          "coordinates": {
            "lat": 63.43117,
            "lon": 10.3923
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/185/484/5_1267554284.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/185/484/5_1267554284.jpg"
          },
          "job_title": "Data Scientist",
          "deadline": 1653948000000,
          "published": 1651739760000,
          "company_name": "AtB",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/185/484/5_1267554284.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/185/484/5_1267554284.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257218277"
        },
        {
          "type": "job",
          "ad_id": 257219752,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Løsningsarkitekt",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651739280000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Løsningsarkitekt",
          "deadline": 1653170400000,
          "published": 1651739280000,
          "company_name": "UDI",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257219752"
        },
        {
          "type": "job",
          "ad_id": 257219290,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Virksomhetsarkitekter",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651739040000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Virksomhetsarkitekt",
          "deadline": 1653170400000,
          "published": 1651739040000,
          "company_name": "UDI",
          "no_of_positions": 3,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257219290"
        },
        {
          "type": "job",
          "ad_id": 257216750,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "We are looking for Tech people within a variety of positions!",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651738860000,
          "coordinates": {
            "lat": 59.90761,
            "lon": 10.75994
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/138/263/338/5_797808335.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/138/263/338/5_797808335.jpg"
          },
          "job_title": "Tech Professionals",
          "deadline": 1655330400000,
          "published": 1651738860000,
          "company_name": "DNB Bank",
          "no_of_positions": 5,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/138/263/338/5_797808335.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/138/263/338/5_797808335.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257216750"
        },
        {
          "type": "job",
          "ad_id": 257218955,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Junior- og seniorutviklere til NAV",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651738860000,
          "coordinates": {
            "lat": 59.91275,
            "lon": 10.79673
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/218/955_520536557.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/218/955_520536557.png"
          },
          "job_title": "Junior og Senior utviklere til NAV",
          "deadline": 1653775200000,
          "published": 1651738860000,
          "company_name": "NAV",
          "no_of_positions": 2,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/218/955_520536557.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/5/257/218/955_520536557.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257218955"
        },
        {
          "type": "job",
          "ad_id": 257218807,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Sikkerhetsarkitekt",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651738740000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Sikkerhetsarkitekt",
          "deadline": 1653170400000,
          "published": 1651738740000,
          "company_name": "UDI",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257218807"
        },
        {
          "type": "job",
          "ad_id": 257218147,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Systemforvaltere",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651738320000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Systemforvalter",
          "deadline": 1653170400000,
          "published": 1651738320000,
          "company_name": "UDI",
          "no_of_positions": 2,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257218147"
        },
        {
          "type": "job",
          "ad_id": 257216889,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Har du nylig fullført en IT-utdannelse?",
          "location": "Oslo",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651737660000,
          "coordinates": {
            "lat": 59.91268,
            "lon": 10.74155
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png"
          },
          "job_title": "IT-konsulenter",
          "published": 1651737660000,
          "company_name": "Hodejakt1",
          "no_of_positions": 5,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/337828029/iad_2310185663046304855hodejakt1_150x150.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257216889"
        },
        {
          "type": "job",
          "ad_id": 257210135,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Come join our great team as a backend developer!",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651736580000,
          "coordinates": {
            "lat": 59.90991,
            "lon": 10.74183
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/5/257/210/135_1510216862.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/5/257/210/135_1510216862.png"
          },
          "job_title": "Backendutvikler",
          "published": 1651736580000,
          "company_name": "Cloud Insurance",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/5/257/210/135_1510216862.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/05/5/257/210/135_1510216862.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257210135"
        },
        {
          "type": "job",
          "ad_id": 257213753,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Innføringsleder",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651735920000,
          "coordinates": {
            "lat": 59.91637,
            "lon": 10.80726
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "job_title": "Innføringsleder",
          "deadline": 1653170400000,
          "published": 1651735920000,
          "company_name": "UDI",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1443213573/iad_7906338071392495864udi_logo_40pxl_rgb.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257213753"
        },
        {
          "type": "job",
          "ad_id": 257213088,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du være med på å utvikle og automatisere våre prosesser?",
          "location": "Hamar",
          "flags": [],
          "timestamp": 1651735500000,
          "coordinates": {
            "lat": 60.79228,
            "lon": 11.07454
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1715385266/iad_7514223599414603689sb1_ostlandet_verti_pos_cmyk.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1715385266/iad_7514223599414603689sb1_ostlandet_verti_pos_cmyk.png"
          },
          "job_title": "Utvikler Digital assistent",
          "deadline": 1653170400000,
          "published": 1651735500000,
          "company_name": "SpareBank 1 Østlandet",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/1715385266/iad_7514223599414603689sb1_ostlandet_verti_pos_cmyk.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/1715385266/iad_7514223599414603689sb1_ostlandet_verti_pos_cmyk.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257213088"
        },
        {
          "type": "job",
          "ad_id": 257209833,
          "main_search_key": "SEARCH_ID_JOB_PARTTIME",
          "heading": "Interessert i nettsideutvikling og ønsker å bidra til et grønnere skifte?",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651734060000,
          "coordinates": {
            "lat": 59.92741,
            "lon": 10.76949
          },
          "ad_type": 43,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/3/712/849/803_921805290.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/3/712/849/803_921805290.jpg"
          },
          "job_title": "Nettsideutvikler",
          "published": 1651734060000,
          "company_name": "Student Consulting Group",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/3/712/849/803_921805290.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/05/3/712/849/803_921805290.jpg"
          },
          "ad_link": "https://www.finn.no/job/parttime/ad.html?finnkode=257209833"
        },
        {
          "type": "job",
          "ad_id": 257205328,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Bouvet søker teamleder med teknisk bakgrunn",
          "location": "Stavanger",
          "flags": [],
          "timestamp": 1651731000000,
          "coordinates": {
            "lat": 58.9162,
            "lon": 5.7325
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/1751836977/20210422/6685cd3d-5010-4e48-a10a-4f7b73f5292a",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/1751836977/20210422/6685cd3d-5010-4e48-a10a-4f7b73f5292a"
          },
          "job_title": "Teamlead med teknisk bakgrunn",
          "published": 1651731000000,
          "company_name": "Bouvet Norge AS",
          "no_of_positions": 3,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/1751836977/20210422/6685cd3d-5010-4e48-a10a-4f7b73f5292a",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/1751836977/20210422/6685cd3d-5010-4e48-a10a-4f7b73f5292a"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257205328"
        },
        {
          "type": "job",
          "ad_id": 257189526,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du bidra i arbeidet med å standardisere for digitale helsetjenester i verdensklasse?",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651695300000,
          "coordinates": {
            "lat": 59.92125,
            "lon": 10.68593
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/6/257/189/526_644803250.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/6/257/189/526_644803250.jpg"
          },
          "job_title": "Rådgiver/seniorrådgiver internasjonale e-helsestandarder",
          "deadline": 1653429600000,
          "published": 1651695300000,
          "company_name": "Direktoratet for e-helse",
          "no_of_positions": 2,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/6/257/189/526_644803250.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/6/257/189/526_644803250.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257189526"
        },
        {
          "type": "job",
          "ad_id": 257062669,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vi søker erfaren javautvikler til spennende oppgaver",
          "location": "Hamar",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651683840000,
          "coordinates": {
            "lat": 60.79566,
            "lon": 11.09153
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/03/9/257/062/669_2061820470.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/03/9/257/062/669_2061820470.png"
          },
          "job_title": "Systemutvikler",
          "published": 1651683840000,
          "company_name": "KulturIT AS",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/03/9/257/062/669_2061820470.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/03/9/257/062/669_2061820470.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257062669"
        },
        {
          "type": "job",
          "ad_id": 246883677,
          "main_search_key": "SEARCH_ID_JOB_PARTTIME",
          "heading": "Vi søker frilansere!",
          "location": "Trondheim",
          "flags": [],
          "timestamp": 1651675260000,
          "coordinates": {
            "lat": 63.3957,
            "lon": 10.3237
          },
          "ad_type": 43,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/2/vertical-0/01/7/246/883/677_1753051795.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/2/vertical-0/01/7/246/883/677_1753051795.png"
          },
          "job_title": "Egenansatt",
          "published": 1651675260000,
          "company_name": "Konsulenttorget.no",
          "no_of_positions": 10,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/2/vertical-0/01/7/246/883/677_1753051795.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/2/vertical-0/01/7/246/883/677_1753051795.png"
          },
          "ad_link": "https://www.finn.no/job/parttime/ad.html?finnkode=246883677"
        },
        {
          "type": "job",
          "ad_id": 257138487,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Computer vision/AI developer",
          "location": "Hønefoss",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651673940000,
          "coordinates": {
            "lat": 60.17518,
            "lon": 10.34604
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/138/487_422158179.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/138/487_422158179.jpg"
          },
          "job_title": "Computer vision engineer",
          "published": 1651673940000,
          "company_name": "Submerged AS",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/138/487_422158179.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/138/487_422158179.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257138487"
        },
        {
          "type": "job",
          "ad_id": 253035521,
          "main_search_key": "SEARCH_ID_JOB_MANAGEMENT",
          "heading": "Vil du jobbe som IT-arkitekt på spennende digitaliseringsprosjekter?",
          "location": "Oslo",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651672560000,
          "coordinates": {
            "lat": 59.92105,
            "lon": 10.67285
          },
          "ad_type": 44,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/1/253/035/521_189364812.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/1/253/035/521_189364812.jpg"
          },
          "job_title": "IT-Arkitekt",
          "published": 1651672560000,
          "company_name": "A-2 Norge AS",
          "no_of_positions": 3,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/1/253/035/521_189364812.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/1/253/035/521_189364812.jpg"
          },
          "ad_link": "https://www.finn.no/job/management/ad.html?finnkode=253035521"
        },
        {
          "type": "job",
          "ad_id": 257139775,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "SRE position at a Nowegian AIOPs company with global ambitions",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651672140000,
          "coordinates": {
            "lat": 59.91302,
            "lon": 10.73651
          },
          "ad_type": 40,
          "job_title": "Site Reliability Engineer",
          "published": 1651672140000,
          "company_name": "AIMS",
          "no_of_positions": 1,
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257139775"
        },
        {
          "type": "job",
          "ad_id": 257139601,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Nyutdannet og vil kode for politiet? ",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651672020000,
          "coordinates": {
            "lat": 59.93,
            "lon": 10.70903
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/179897143/20201109/e29b12de-460c-4b8b-9deb-3009bd97b5d0",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/179897143/20201109/e29b12de-460c-4b8b-9deb-3009bd97b5d0"
          },
          "job_title": "Nyutdannede utviklere",
          "deadline": 1653256800000,
          "published": 1651672020000,
          "company_name": "Politiets IKT-tjenester",
          "no_of_positions": 2,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/179897143/20201109/e29b12de-460c-4b8b-9deb-3009bd97b5d0",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/179897143/20201109/e29b12de-460c-4b8b-9deb-3009bd97b5d0"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257139601"
        },
        {
          "type": "job",
          "ad_id": 257138694,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Big Data Engineer",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651671480000,
          "coordinates": {
            "lat": 59.91302,
            "lon": 10.73651
          },
          "ad_type": 40,
          "job_title": "Big Data Engineer",
          "published": 1651671480000,
          "company_name": "AIMS",
          "no_of_positions": 1,
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257138694"
        },
        {
          "type": "job",
          "ad_id": 257105477,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du bidra til å skape de beste tjenestene i fremtidens marked?",
          "location": "Bergen",
          "flags": [],
          "timestamp": 1651671000000,
          "coordinates": {
            "lat": 60.40586,
            "lon": 5.32326
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/105/477_232454307.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/105/477_232454307.png"
          },
          "job_title": "Tjenestedesigner",
          "published": 1651671000000,
          "company_name": "PwC",
          "no_of_positions": 2,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/105/477_232454307.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/7/257/105/477_232454307.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257105477"
        },
        {
          "type": "job",
          "ad_id": 257129300,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Digitaliseringskoordinator",
          "location": "Horten",
          "flags": [],
          "timestamp": 1651670280000,
          "coordinates": {
            "lat": 59.41517,
            "lon": 10.48496
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/0/257/129/300_548676050.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/0/257/129/300_548676050.jpg"
          },
          "job_title": "Digitaliseringskoordinator",
          "deadline": 1652997600000,
          "published": 1651670280000,
          "company_name": "Horten kommune",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/0/257/129/300_548676050.jpg",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/0/257/129/300_548676050.jpg"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257129300"
        },
        {
          "type": "job",
          "ad_id": 257130234,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Er du vår nye IT-Driftsleder?",
          "location": "Larvik",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651670100000,
          "coordinates": {
            "lat": 59.04929,
            "lon": 10.06491
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/1/194/874/292/1_1807383563.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/1/194/874/292/1_1807383563.png"
          },
          "job_title": "IT-Driftsleder",
          "published": 1651670100000,
          "company_name": "IKM Instrutek AS",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/1/194/874/292/1_1807383563.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/1/194/874/292/1_1807383563.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257130234"
        },
        {
          "type": "job",
          "ad_id": 257133762,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "We are looking for our new Frontend developer",
          "location": "Grålum",
          "flags": [],
          "timestamp": 1651668720000,
          "coordinates": {
            "lat": 59.29863,
            "lon": 11.05992
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/1734219698/20200116/da9af397-ecff-4e34-ad66-d173c1a167c4",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/1734219698/20200116/da9af397-ecff-4e34-ad66-d173c1a167c4"
          },
          "job_title": "Frontend Developer",
          "deadline": 1654293600000,
          "published": 1651668720000,
          "company_name": "Simployer",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/logo/1734219698/20200116/da9af397-ecff-4e34-ad66-d173c1a167c4",
            "path": "https://images.finncdn.no/dynamic/default/logo/logo/1734219698/20200116/da9af397-ecff-4e34-ad66-d173c1a167c4"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257133762"
        },
        {
          "type": "job",
          "ad_id": 249995236,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Triona AS ønsker å ansette ivrige og engasjerte Systemutviklere på .Net og Java",
          "location": "Tiller",
          "flags": [
            "job-easy-apply"
          ],
          "timestamp": 1651668420000,
          "coordinates": {
            "lat": 63.36468,
            "lon": 10.37383
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/6/249/995/236_1426766582.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/6/249/995/236_1426766582.png"
          },
          "job_title": "Systemutvikler",
          "deadline": 1653775200000,
          "published": 1651668420000,
          "company_name": "Triona AS",
          "no_of_positions": 3,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/6/249/995/236_1426766582.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-0/04/6/249/995/236_1426766582.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=249995236"
        },
        {
          "type": "job",
          "ad_id": 257132025,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Vil du bli en del av vårt Microsoft utviklingsmiljø?",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651667880000,
          "coordinates": {
            "lat": 59.9236,
            "lon": 10.87129
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/5/257/132/025_851898984.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/5/257/132/025_851898984.png"
          },
          "job_title": "Plattformutvikler",
          "deadline": 1653429600000,
          "published": 1651667880000,
          "company_name": "Etterretningstjenesten",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/5/257/132/025_851898984.png",
            "path": "https://images.finncdn.no/dynamic/default/2022/5/vertical-1/04/5/257/132/025_851898984.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257132025"
        },
        {
          "type": "job",
          "ad_id": 257131850,
          "main_search_key": "SEARCH_ID_JOB_FULLTIME",
          "heading": "Do you want to work with big data and machine learning for one of Norway´s most popular websites?",
          "location": "Oslo",
          "flags": [],
          "timestamp": 1651667820000,
          "coordinates": {
            "lat": 59.9139,
            "lon": 10.74161
          },
          "ad_type": 40,
          "logo": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/-3002/iad_1359802226105336855finn-logo-hovedlogo-rgb-ikketransp.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/-3002/iad_1359802226105336855finn-logo-hovedlogo-rgb-ikketransp.png"
          },
          "job_title": "Data Scientist",
          "deadline": 1653429600000,
          "published": 1651667820000,
          "company_name": "FINN.no",
          "no_of_positions": 1,
          "image": {
            "url": "https://images.finncdn.no/dynamic/default/logo/result/-3002/iad_1359802226105336855finn-logo-hovedlogo-rgb-ikketransp.png",
            "path": "https://images.finncdn.no/dynamic/default/logo/result/-3002/iad_1359802226105336855finn-logo-hovedlogo-rgb-ikketransp.png"
          },
          "ad_link": "https://www.finn.no/job/fulltime/ad.html?finnkode=257131850"
        }
      ],
    }
    const adverts: any[] = [];
    let id = 0;
    advertsFinn.docs.forEach((doc: any) => {
      if(doc.hasOwnProperty("image")
        && doc.hasOwnProperty("job_title")
        && doc.hasOwnProperty("company_name")
        && doc.hasOwnProperty("heading")
      ) {
        adverts.push({
          id: id,
          title: doc.job_title,
          image: doc.image.url,
          company: doc.company_name,
          description: doc.heading
        });
        id += 1;
      }
    })
    return {adverts};
  },
})
</script>
