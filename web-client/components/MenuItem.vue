<template>
  <li class="font-medium text-lg text-gray-600">
    <a :class="[activeLink, collapsedLink]"
       class="flex items-center gap-2.5 p-4 rounded transition duration-300 ease-in-out hover:bg-gray-200" :href="linkItem.href">
      <span :class="linkItem.icon"></span>
      <div v-if="!this.$parent.isCollapsed" class="">
        <p>{{ linkItem.text }}</p>
      </div>
    </a>
  </li>
</template>

<script>
export default {
  props: {
    linkItem: Object
  },
  computed: {
    activeLink() {
      return this.$route.path == this.linkItem.href ? 'bg-gray-100 text-black' : '';
    },
    collapsedLink() {
      return this.$parent.isCollapsed ?  'justify-center'  : '';
    }
  }
}
</script>
