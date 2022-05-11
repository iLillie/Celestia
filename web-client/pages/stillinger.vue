<template>
  <main class="p-8 grid main gap-8 content-start overflow-y-auto max-w-min">
    <AdvertItem v-for="advert in adverts" @openModal="OpenModal()" :advert="advert" :key="advert.id"></AdvertItem>
    <AdvertModal @closeModal="() => CloseModal()" v-if="modalOpen">
    </AdvertModal>
  </main>
</template>

<style>
body {
  background-color: #F7F7F8;
}

.main {
  justify-items: start;
  justify-content: start;
  grid-template-columns: 1fr 1fr 1fr 1fr;
}
</style>

<script lang="ts">
import Vue from 'vue'
import { mapMutations } from 'vuex'


export default Vue.extend({
  name: 'Stillinger',
  mounted() {
    if(this.adverts.length > 0) return;
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
      ],
    }
    let id = 0;
    advertsFinn.docs.forEach((doc: any) => {
      if(doc.hasOwnProperty("image")
        && doc.hasOwnProperty("job_title")
        && doc.hasOwnProperty("company_name")
        && doc.hasOwnProperty("heading")
      ) {
        this.$store.commit('advert/add', ({
          id: id,
          title: doc.job_title,
          image: doc.image.url,
          company: doc.company_name,
          description: doc.heading,
          location: doc.location,
          adLink: doc.ad_link,
          deadline: doc.deadline
        }))
        id += 1;
      }
    })
  },
  computed: {
    adverts() {
      return this.$store.state.advert.adverts;
    }
  },
  data() {
    return {
      modalOpen: false
    }
  },
  methods: {
    OpenModal() {
      this.modalOpen = !this.modalOpen;
    },
    CloseModal() {
      this.modalOpen = false;
    }
  }
})
</script>
